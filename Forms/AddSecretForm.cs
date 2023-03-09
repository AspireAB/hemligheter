using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hemligheter.Helpers;
using Hemligheter.Services;

namespace Hemligheter
{
    public partial class AddSecretForm : Form
    {
        private PasswordHelper _passwordHelper = new PasswordHelper();
        private Secret _secret;

        public AddSecretForm(IEnumerable<Store> stores, string path = "", Store store = null)
        {
            InitializeComponent();

            labelErrorMessage.Visible = false;

            if (store != null)
            {
                comboBoxStores.Items.Add(store);
            }
            else
            {
                var storeArray = stores.Where(s => s.Permissions.HasFlag(StorePermissions.Write)).ToArray();
                comboBoxStores.Items.AddRange(storeArray);
            }

            comboBoxStores.SelectedIndex = 0;

            textBoxName.Text = path.Length > 0 ? path + "-" : path;
            textBoxName.Leave += TextBox_Leave;
            textBoxSecret.Leave += TextBox_Leave;

            textBoxName.Focus();
        }

        public AddSecretForm(Secret secret)
        {
            InitializeComponent();

            this._secret = secret;

            labelErrorMessage.Visible = false;
            this.Text = "Redigera hemlighet";

            comboBoxStores.Items.Add(secret.Store);
            comboBoxStores.SelectedIndex = 0;

            textBoxName.Text = secret.Identifier;
            textBoxName.Enabled = false;
            textBoxAccount.Text = secret.Account;
            textBoxUrl.Text = secret.Url;
            textBoxSecret.Leave += TextBox_Leave;
            textBoxSecret.Focus();
        }

        private NewSecret GetNewSecret()
        {
            var name = textBoxName.Text;
            var value = textBoxSecret.Text;
            var account = textBoxAccount.Text;
            var url = textBoxUrl.Text;

            return new NewSecret(name, value, account, url);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                SetErrorMessage("Du måste ange ett namn", textBoxName);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSecret.Text))
            {
                SetErrorMessage("Du måste ange en hemlighet", textBoxSecret);
                return;
            }

            var selectedStore = comboBoxStores.SelectedItem as Store;
            if (await selectedStore.AddSecretAsync(GetNewSecret()))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                SetErrorMessage("Kunde inte spara hemlighet");
            }
        }

        private void SetErrorMessage(string errorMessage, Control control = null)
        {
            labelErrorMessage.Text = errorMessage;
            labelErrorMessage.Visible = true;

            if (control != null)
            {
                control.BackColor = Color.MistyRose;
            }
        }

        private void buttonShowSecret_Click(object sender, EventArgs e)
        {
            textBoxSecret.UseSystemPasswordChar = !textBoxSecret.UseSystemPasswordChar;
        }

        private void buttonGenerateSecret_Click(object sender, EventArgs e)
        {
            textBoxSecret.Text = _passwordHelper.GeneratePassword();
        }

        private async void AddSecretForm_Load(object sender, EventArgs e)
        {
            if (_secret != null && _secret.CanRead)
            {
                textBoxSecret.Text = await _secret.GetValueAsync();
            }
        }
    }
}
