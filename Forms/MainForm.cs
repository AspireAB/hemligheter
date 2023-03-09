using Hemligheter.Extensions;
using Hemligheter.Helpers;
using Hemligheter.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemligheter
{
    public partial class MainForm : Form
    {
        public static MainForm InitApplication()
        {
            if (!Mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("Hemligheter körs redan!", "Hemligheter", MessageBoxButtons.OK);
                Application.Exit();
                return null;
            }

            return new MainForm();
        }

        private static readonly Mutex Mutex = new Mutex(false, "hemligheter");

        delegate void ClipDelegate(string secretName, string secretValue, bool setAccountInsteadOfValue);

        private readonly IStoreProvider _storeProvider;
        private readonly SettingsService _settingsService;
        private readonly InlineSearchForm _inlineSearchForm;

        private IntPtr _ClipboardViewerNext;
        private IEnumerable<Store> _stores;
        private IEnumerable<Secret> _secrets;
        private bool showUpdateAvailableAlert = true;

        public MainForm()
        {
            InitializeComponent();
            SetVersionInTitle();

            _settingsService = new SettingsService();

#if DEBUG
            _storeProvider = new FakeStoreProvider();
#else
            _storeProvider = new KeyVaultStoreProvider(_settingsService);
#endif

            _inlineSearchForm = new InlineSearchForm(_settingsService);
            _inlineSearchForm.SearchComplete += _inlineSearchForm_OnSearchComplete;

            contextMenuStripTreeLeaf.Opening += ContextMenuStripTreeLeaf_Opening;
            contextMenuStripTreeNode.Opening += ContextMenuStripTreeNode_Opening;
        }

        private void ContextMenuStripTreeLeaf_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Secret secret)
            {
                toolStripMenuItemEdit.Enabled = secret.CanEdit;
                toolStripMenuItemDelete.Enabled = secret.CanDelete;
            }
        }

        private void ContextMenuStripTreeNode_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Store store)
            {
                toolStripMenuItemAddSecret.Enabled = store.Permissions.HasFlag(StorePermissions.Write);
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            RegisterClipboardViewer();
            await CheckForUpdate();
            await RefreshSecretList();
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - Width, Screen.PrimaryScreen.WorkingArea.Bottom - Height);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ActiveControl = textBoxSearch;
            textBoxSearch.Focus();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                if (_inlineSearchForm.Visible) _inlineSearchForm.Close();
                UnregisterClipboardViewer();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private async void _inlineSearchForm_OnSearchComplete(object sender, SecretSearchResult result)
        {
            await GetSecretAndSetToClipboard(result.Secret, result.ResultType == ResultType.Account);
        }

        private void RegisterClipboardViewer()
        {
            _ClipboardViewerNext = User32.SetClipboardViewer(Handle);
        }

        private void UnregisterClipboardViewer()
        {
            User32.ChangeClipboardChain(Handle, _ClipboardViewerNext);
        }

        private void SetVersionInTitle()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            var version = fvi.FileVersion;

            toolStripLabelAppIcon.ToolTipText += $@" {version}";
        }

        private void SetLoading(bool loading)
        {
            loadingIndicator.Enabled = loading;
            loadingIndicator.Visible = loading;
        }

        private async Task RefreshSecretList()
        {
            SetLoading(true);

            if (ConnectivityHelper.IsConnectedToInternet())
            {
                _stores = await _storeProvider.GetStores();
                var secretsInStores = await Task.WhenAll(_stores.Select(async store => await store.GetSecretsAsync()));
                _secrets = secretsInStores.SelectMany(s => s).OrderBy(s => s.Name).ToList();

                FillTreeView(_secrets);
                _inlineSearchForm.LoadSecrets(_secrets);
            }

            SetLoading(false);
        }

        private void FillTreeView(IEnumerable<Secret> secrets)
        {
            tvKeys.BeginUpdate();
            tvKeys.Nodes.Clear();

            foreach (var secret in secrets)
            {
                CreateTreeFromKeyName(secret, secret.Name.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries), tvKeys.Nodes);
            }

            tvKeys.EndUpdate();
        }

        private void CreateTreeFromKeyName(Secret secret, IEnumerable<string> keyParts, TreeNodeCollection nodes)
        {
            var parts = keyParts.ToList();
            if (!parts.Any())
                return;

            var part = parts.First();
            if (nodes.ContainsKey(part))
            {
                CreateTreeFromKeyName(secret, parts.Skip(1), nodes[part].Nodes);
                return;
            }

            var isLeafNode = parts.Count == 1;
            var imageIndex = isLeafNode ? 2 : 0;
            var newNode = nodes.Add(part, part, imageIndex, imageIndex);

            newNode.Tag = isLeafNode ? (object)secret : (object)secret.Store;

            CreateTreeFromKeyName(secret, parts.Skip(1), newNode.Nodes);
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_inlineSearchForm.Visible) _inlineSearchForm.Close();

            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                notifyIcon1.ContextMenuStrip.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
                Show();
                Activate();
            }
        }

        private void tvKeys_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = e.Node.SelectedImageIndex = 1;
        }

        private void tvKeys_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = e.Node.SelectedImageIndex = 0;
        }

        private async void tvKeys_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is Secret secret)
            {
                await OpenSecret(secret);
            }
        }

        private async Task OpenSecret(Secret secret)
        {
            if (secret.HasMetadata)
            {
                var editSecretForm = new ViewSecretForm(secret);

                if (editSecretForm.ShowDialog() == DialogResult.OK)
                {
                    await GetSecretAndSetToClipboard(secret);
                }
            }
            else
            {
                await GetSecretAndSetToClipboard(secret);
            }
        }

        private void EnsurePreviousWindowHasFocus()
        {
            var invisibleForm = new InvisibleForm();
            invisibleForm.Show();
            invisibleForm.Hide();
        }

        private async Task GetSecretAndSetToClipboard(Secret secret, bool setAccountInsteadOfValue = false)
        {
            if (secret.CanRead == false)
            {
                MessageBox.Show("Du har inte behörighet att se denna hemlighet", "Obehörig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnsurePreviousWindowHasFocus();
            Close();

            var secretValue = secret.Account;

            if (setAccountInsteadOfValue == false || string.IsNullOrWhiteSpace(secretValue))
            {
                secretValue = await secret.GetValueAsync();
            }

            if (string.IsNullOrWhiteSpace(secretValue))
            {
                notifyIcon1.ShowBalloonTip(3000, "Hemlighet saknas", "Hittade ingenting att kopiera", ToolTipIcon.Error);
                return;
            }

            if (_settingsService.GetSettings().UseClipboard)
            {
                SetClipboardDataAndNotify(secret.Name, secretValue, setAccountInsteadOfValue);
            }
            else
            {
                Thread.Sleep(500);
                SendKeys.SendWait(secretValue);
            }
        }

        private void SetClipboardDataAndNotify(string secretName, string secretValue, bool setAccountInsteadOfValue = false)
        {
            ClipboardHelper.SetClipboardData(secretValue);
            var accountOrSecret = setAccountInsteadOfValue ? "kontot för" : "hemligheten";
            notifyIcon1.ShowBalloonTip(3000, "Hemlighet kopierad", $"Kopierade {accountOrSecret} '{secretName}' till urklipp", ToolTipIcon.None);
        }

        private async void tvKeys_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (tvKeys.SelectedNode?.Tag is Secret secret)
            {
                await OpenSecret(secret);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await RefreshSecretList();
        }

        private async void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm(_settingsService);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await RefreshSecretList();
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch ((Msgs)m.Msg)
            {
                case Msgs.WM_DRAWCLIPBOARD:
                    var text = ClipboardHelper.GetKvLinkFromClipboard();
                    if (text != null) HandleKvLink(text);
                    User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    break;
                case Msgs.WM_CHANGECBCHAIN:
                    if (m.WParam == _ClipboardViewerNext)
                    {
                        _ClipboardViewerNext = m.LParam;
                    }
                    else
                    {
                        User32.SendMessage(_ClipboardViewerNext, m.Msg, m.WParam, m.LParam);
                    }
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void HandleKvLink(string text)
        {
            var uri = text.ToVerifiedUri("kv");
            var secretName = uri.UserInfo;
            var store = $"https://{uri.Authority}.vault.azure.net/";

            Task.Run(async () =>
            {
                try
                {
                    var secretValue = await _storeProvider.FindSecretValue(secretName, store);
                    if (string.IsNullOrWhiteSpace(secretValue) == false)
                    {
                        Invoke(new ClipDelegate(SetClipboardDataAndNotify), secretName, secretValue, false);
                    }
                }
                catch
                {
                    notifyIcon1.ShowBalloonTip(3000, "Kunde inte hämta hemlighet", $"Fel vid hämtning av '{secretName}' från {store}", ToolTipIcon.None);
                }
            });
        }

        private async void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Secret secret)
            {
                if (MessageBox.Show($"Vill du verkligen ta bort hemligheten '{secret.Name}'?", "Bekräfta borttagning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;

                if (await secret.DeleteAsync())
                {
                    await RefreshSecretList();
                }
            }
        }

        private void tvKeys_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) != 0)
            {
                if (e.Node.Tag is Secret)
                {
                    tvKeys.SelectedNode = e.Node;
                    contextMenuStripTreeLeaf.Show(tvKeys, new Point(e.X, e.Y));
                }
                else if (e.Node.Tag is Store)
                {
                    tvKeys.SelectedNode = e.Node;
                    contextMenuStripTreeNode.Show(tvKeys, new Point(e.X, e.Y));
                }
            }
        }

        private void kopieraKvlänkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Secret secret)
            {
                ClipboardHelper.SetClipboardData($"Länk: kv://{secret.Identifier}@{secret.Store.Name}");
            }
        }

        private async void toolStripMenuItemAddSecret_Click(object sender, EventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Store store)
            {
                var node = tvKeys.SelectedNode;
                var nodeName = GetNodePathName(node);

                var addSecretForm = new AddSecretForm(_stores, nodeName, store);
                await OpenAddOrEditDialog(addSecretForm);
            }
        }

        private static string GetNodePathName(TreeNode node)
        {
            var pathNames = new List<string>();
            var currentNode = node;

            while (currentNode.Parent != null)
            {
                pathNames.Insert(0, currentNode.Name);
                currentNode = currentNode.Parent;
            }

            return string.Join("-", pathNames);
        }

        private async void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (tvKeys.SelectedNode?.Tag is Secret secret)
            {
                var addSecretForm = new AddSecretForm(secret);
                await OpenAddOrEditDialog(addSecretForm);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var addSecretForm = new AddSecretForm(_stores);
            await OpenAddOrEditDialog(addSecretForm);
        }

        private async Task OpenAddOrEditDialog(AddSecretForm addSecretForm)
        {
            if (addSecretForm.ShowDialog(this) == DialogResult.OK)
            {
                await RefreshSecretList();
            }
        }

        private async void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ClearSearch();
            }
            else if (e.KeyCode == Keys.Enter && textBoxSearch.TextLength > 0)
            {
                var filteredSecrets = GetFilteredSecrets();
                if (filteredSecrets.Any())
                {
                    await GetSecretAndSetToClipboard(filteredSecrets.First(), e.Alt);
                    ClearSearch();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            labelSearchPlaceholder.Visible = textBoxSearch.TextLength == 0;

            if (textBoxSearch.Text == string.Empty)
            {
                FillTreeView(_secrets);
            }
            else
            {
                var filteredSecrets = GetFilteredSecrets();
                FillTreeView(filteredSecrets);
                tvKeys.ExpandAll();
            }
        }

        private void ClearSearch()
        {
            textBoxSearch.Clear();
            ActiveControl = null;
        }

        private void labelSearchPlaceholder_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
            ActiveControl = textBoxSearch;
        }

        private List<Secret> GetFilteredSecrets()
        {
            var filterText = textBoxSearch.Text.ToLowerInvariant();
            var queryWords = filterText.Split(' ');
            var filteredSecrets = _secrets.Where(s => queryWords.All(s.Name.ToLowerInvariant().Contains)).ToList();
            return filteredSecrets;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripLabelAppIcon_Click(object sender, EventArgs e)
        {
            OpenBugReportWindow();
        }

        private void rapporteraEnBuggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBugReportWindow();
        }

        private static void OpenBugReportWindow()
        {
            Process.Start("https://github.com/Nethouse/hemligheter/issues");
        }

        private void buttonCloseUpdateNotification_Click(object sender, EventArgs e)
        {
            panelUpdateAvailable.Visible = false;
            showUpdateAvailableAlert = false;
        }

        private void buttonInstallUpdate_Click(object sender, EventArgs e)
        {
            UpdateHelper.ApplyUpdate();
        }

        private async void timerCheckForUpdates_Tick(object sender, EventArgs e)
        {
            await CheckForUpdate();
        }

        private async Task CheckForUpdate()
        {
            var hasUpdate = await UpdateHelper.CheckForUpdates();

            if (hasUpdate && showUpdateAvailableAlert)
            {
                panelUpdateAvailable.Show();
            }
        }
    }
}
