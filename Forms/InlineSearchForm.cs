using Hemligheter.Helpers;
using Hemligheter.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hemligheter
{
    public partial class InlineSearchForm : Form
    {
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                // Enable drop shadow background on the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public event EventHandler<SecretSearchResult> SearchComplete;

        private readonly SettingsService _settingsService;

        private IEnumerable<Secret> _secrets;
        private LinkedList<Secret> _history;

        public InlineSearchForm(SettingsService settingsService)
        {
            _settingsService = settingsService;
            _history = new LinkedList<Secret>();

            InitializeComponent();
            RegisterHotKey();
        }

        public void LoadSecrets(IEnumerable<Secret> secrets)
        {
            _secrets = secrets;
        }

        private void RegisterHotKey()
        {
            User32.RegisterHotKey(Handle, (int)Hotkey.Search, User32.Modifiers.Alt | User32.Modifiers.Control, Keys.S);
        }

        protected override void WndProc(ref Message message)
        {
            if ((Msgs)message.Msg == Msgs.WM_HOTKEY)
            {
                int id = message.WParam.ToInt32();

                if (id == (int)Hotkey.Search)
                {
                    ShowIfAllowed();
                }
            }

            base.WndProc(ref message);
        }

        private void ShowIfAllowed()
        {
            bool shouldBeShown = _settingsService.GetSettings().UseSearchForm;
            bool hasLoadedSecrets = _secrets != null && _secrets.Any();

            if (shouldBeShown && hasLoadedSecrets)
            {
                CenterToActiveScreen();
                Show();
                Activate();
                Focus();
            }
        }

        private void CenterToActiveScreen()
        {
            var screen = Screen.FromPoint(Cursor.Position);
            this.StartPosition = FormStartPosition.Manual;
            this.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - this.Width / 2;
            this.Top = screen.Bounds.Top + screen.Bounds.Height / 3 - this.Height / 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listViewSearchResult.Clear();
            listViewSearchResult.Groups.Clear();

            bool userHasEnteredText = string.IsNullOrWhiteSpace(textBoxSearch.Text) == false;
            labelSearchPlaceholder.Visible = userHasEnteredText == false;

            if (userHasEnteredText)
            {
                FillSecretList();
            }
            else
            {
                FillSecretListFromHistory();
            }
        }

        private void FillSecretList()
        {
            var secrets = GetFilteredSecrets();
            var stores = secrets.Select(secret => secret.Store).Distinct();

            ListViewGroup[] groups = stores.Select(MapStoreToListViewGroup).ToArray();
            ListViewItem[] items = secrets.Select(secret => MapSecretToListViewItem(secret, groups.Single(g => g.Tag == secret.Store))).ToArray();

            LoadListView(groups, items);
        }

        private void FillSecretListFromHistory()
        {
            var secrets = _history.ToList().Take(5);

            ListViewGroup group = new ListViewGroup("NYLIGEN ANVÄNDA");
            ListViewItem[] items = secrets.Select(secret => MapSecretToListViewItem(secret, group)).ToArray();

            LoadListView(new[] { group }, items);
        }

        private void LoadListView(ListViewGroup[] groups, ListViewItem[] items)
        {
            listViewSearchResult.BeginUpdate();
            listViewSearchResult.Groups.AddRange(groups);
            listViewSearchResult.Items.AddRange(items);
            listViewSearchResult.Visible = listViewSearchResult.Items.Count > 0;
            listViewSearchResult.Height = groups.Length * 25 + items.Length * 20;
            listViewSearchResult.EndUpdate();

            SelectNextResultItem();
        }

        private ListViewGroup MapStoreToListViewGroup(Store store)
        {
            return new ListViewGroup
            {
                Header = store.Name.ToUpperInvariant(),
                Tag = store
            };
        }

        private ListViewItem MapSecretToListViewItem(Secret secret, ListViewGroup group)
        {
            return new ListViewItem
            {
                Tag = secret,
                Text = secret.Identifier,
                Group = group
            };
        }

        private List<Secret> GetFilteredSecrets()
        {
            var filterText = textBoxSearch.Text.Trim().ToLowerInvariant();
            var queryWords = filterText.Split(' ');
            var filteredSecrets = _secrets.Where(s => queryWords.All(s.Identifier.ToLowerInvariant().Contains)
                || queryWords.All(s.Account.ToLowerInvariant().Contains) 
                || queryWords.All(s.Url.ToLowerInvariant().Contains))
                .Take(10).OrderBy(s => s.Name).ToList();
            return filteredSecrets;
        }

        private void textBoxPlaceholder_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        private void textBoxPlaceholder_Click(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ConfirmSelection(e.Alt);
                    Hide();
                    break;
                case Keys.Escape:
                    Hide();
                    break;
                case Keys.Up:
                    SelectPreviousResultItem();
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Down:
                    SelectNextResultItem();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void SelectPreviousResultItem()
        {
            if (listViewSearchResult.Items.Count == 0) return;

            int previousIndex = 0;

            if (listViewSearchResult.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewSearchResult.SelectedIndices[0];
                previousIndex = Math.Max(selectedIndex - 1, 0);
                listViewSearchResult.Items[selectedIndex].Selected = false;
            }

            listViewSearchResult.Items[previousIndex].Selected = true;
        }

        private void SelectNextResultItem()
        {
            if (listViewSearchResult.Items.Count == 0) return;

            int nextIndex = 0;

            if (listViewSearchResult.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewSearchResult.SelectedIndices[0];
                nextIndex = Math.Min(selectedIndex + 1, listViewSearchResult.Items.Count - 1);
                listViewSearchResult.Items[selectedIndex].Selected = false;
            }

            listViewSearchResult.Items[nextIndex].Selected = true;
        }

        private void ConfirmSelection(bool selectAccountInsteadOfValue)
        {
            if (listViewSearchResult.Items.Count == 0) return;

            var selectedSecret = listViewSearchResult.SelectedItems[0].Tag as Secret;
            if (selectedSecret != null)
            {
                _history.Remove(selectedSecret);
                _history.AddFirst(selectedSecret);

                if (string.IsNullOrWhiteSpace(selectedSecret.Account))
                {
                    selectAccountInsteadOfValue = false;
                }

                SearchComplete?.Invoke(this, new SecretSearchResult(selectedSecret, selectAccountInsteadOfValue ? ResultType.Account : ResultType.SecretValue));
            }
        }

        private void InlineSearchForm_Deactivate(object sender, EventArgs e)
        {
            if (Visible)
                Hide();
        }

        private void InlineSearchForm_Activated(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
            listViewSearchResult.Clear();
            listViewSearchResult.Groups.Clear();

            FillSecretListFromHistory();
        }

        private void listViewSearchResult_ItemActivate(object sender, EventArgs e)
        {
            ConfirmSelection(ModifierKeys.HasFlag(Keys.Alt));
        }
    }
}
