using Hemligheter.Services;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemligheter
{
    public partial class ViewSecretForm : Form
    {
        private readonly Secret _secret;

        public ViewSecretForm(Secret secret)
        {
            InitializeComponent();

            textBoxName.Text = secret.Identifier;
            textBoxAccount.Text = secret.Account;
            textBoxUrl.Text = secret.Url;
            buttonOpenUrl.Enabled = Uri.IsWellFormedUriString(secret.Url, UriKind.RelativeOrAbsolute);
            labelUpdated.Text = secret.Updated.HasValue ? secret.Updated.Value.ToString("yyyy-MM-dd HH:mm") : "okänt";
            buttonShowSecret.Enabled = secret.CanRead;

            textBoxAccount.Focus();

            var settingsService = new SettingsService();
            var settings = settingsService.GetSettings();

            buttonOpenSecret.Text = (settings.UseClipboard ? "Kopiera" : "Skriv") + " hemlighet";
            this._secret = secret;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonOpenUrl_Click(object sender, EventArgs e)
        {
            var url = textBoxUrl.Text;

            if ((url.StartsWith("http") || url.StartsWith("www")) == false)
            {
                url = "http://" + url;
            }

            Process.Start(url);
        }

        private async void buttonShowSecret_Click(object sender, EventArgs e)
        {
            textBoxSecret.UseSystemPasswordChar = !textBoxSecret.UseSystemPasswordChar;

            if (textBoxSecret.UseSystemPasswordChar == false)
            {
                textBoxSecret.Clear();
                textBoxSecret.Text = await _secret.GetValueAsync();
            }
            else
            {
                textBoxSecret.Text = "hemlighet";
            }
        }
    }
}
