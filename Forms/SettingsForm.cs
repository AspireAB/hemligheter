using Hemligheter.Services;
using System;
using System.Windows.Forms;

namespace Hemligheter
{
    public partial class SettingsForm : Form
    {
        private readonly SettingsService _service;
        private readonly Settings _settings;

        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(SettingsService service) : this()
        {
            _service = service;
            _settings = _service.GetSettings();

            textBoxAuthorities.Text = string.Join(Environment.NewLine, _settings.Authorities) + Environment.NewLine;
            checkBoxUseClipboard.Checked = _settings.UseClipboard;
            checkBoxUseSearchForm.Checked = _settings.UseSearchForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var authorities = textBoxAuthorities.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            _settings.Authorities = authorities;
            _settings.UseClipboard = checkBoxUseClipboard.Checked;
            _settings.UseSearchForm = checkBoxUseSearchForm.Checked;

            _service.SaveSettings(_settings);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
