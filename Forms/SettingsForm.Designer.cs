namespace Hemligheter
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxUseClipboard = new System.Windows.Forms.CheckBox();
            this.checkBoxUseSearchForm = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthorities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 168);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(144, 168);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 31);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Avbryt";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // checkBoxUseClipboard
            // 
            this.checkBoxUseClipboard.AutoSize = true;
            this.checkBoxUseClipboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseClipboard.Location = new System.Drawing.Point(12, 12);
            this.checkBoxUseClipboard.Name = "checkBoxUseClipboard";
            this.checkBoxUseClipboard.Size = new System.Drawing.Size(168, 19);
            this.checkBoxUseClipboard.TabIndex = 5;
            this.checkBoxUseClipboard.Text = "Spara hemligheter i urklipp";
            this.checkBoxUseClipboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseSearchForm
            // 
            this.checkBoxUseSearchForm.AutoSize = true;
            this.checkBoxUseSearchForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUseSearchForm.Location = new System.Drawing.Point(12, 38);
            this.checkBoxUseSearchForm.Name = "checkBoxUseSearchForm";
            this.checkBoxUseSearchForm.Size = new System.Drawing.Size(230, 19);
            this.checkBoxUseSearchForm.TabIndex = 6;
            this.checkBoxUseSearchForm.Text = "Använd global sökfunktion (Ctrl-Alt-S)";
            this.checkBoxUseSearchForm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hemlighetskällor";
            // 
            // textBoxAuthorities
            // 
            this.textBoxAuthorities.AcceptsReturn = true;
            this.textBoxAuthorities.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorities.Location = new System.Drawing.Point(12, 88);
            this.textBoxAuthorities.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAuthorities.Multiline = true;
            this.textBoxAuthorities.Name = "textBoxAuthorities";
            this.textBoxAuthorities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAuthorities.Size = new System.Drawing.Size(260, 63);
            this.textBoxAuthorities.TabIndex = 9;
            this.textBoxAuthorities.Text = "";
            this.textBoxAuthorities.WordWrap = false;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAuthorities);
            this.Controls.Add(this.checkBoxUseSearchForm);
            this.Controls.Add(this.checkBoxUseClipboard);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inställningar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxUseClipboard;
        private System.Windows.Forms.CheckBox checkBoxUseSearchForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthorities;
    }
}