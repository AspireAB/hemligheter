namespace Hemligheter
{
    partial class AddSecretForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSecretForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStores = new System.Windows.Forms.ComboBox();
            this.buttonShowSecret = new System.Windows.Forms.Button();
            this.buttonGenerateSecret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(14, 77);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn* (använd - för att skapa grupper)";
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecret.Location = new System.Drawing.Point(14, 125);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.Size = new System.Drawing.Size(198, 23);
            this.textBoxSecret.TabIndex = 2;
            this.textBoxSecret.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hemlighet*";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(14, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(256, 36);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Spara";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccount.Location = new System.Drawing.Point(14, 175);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(256, 23);
            this.textBoxAccount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Konto / användarnamn";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(14, 223);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(256, 23);
            this.textBoxUrl.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "URL";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErrorMessage.Location = new System.Drawing.Point(0, 254);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(284, 21);
            this.labelErrorMessage.TabIndex = 13;
            this.labelErrorMessage.Text = "Felmeddelande";
            this.labelErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plats";
            // 
            // comboBoxStores
            // 
            this.comboBoxStores.BackColor = System.Drawing.Color.White;
            this.comboBoxStores.DisplayMember = "Name";
            this.comboBoxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStores.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStores.FormattingEnabled = true;
            this.comboBoxStores.Location = new System.Drawing.Point(14, 30);
            this.comboBoxStores.MaxDropDownItems = 100;
            this.comboBoxStores.Name = "comboBoxStores";
            this.comboBoxStores.Size = new System.Drawing.Size(256, 23);
            this.comboBoxStores.Sorted = true;
            this.comboBoxStores.TabIndex = 16;
            // 
            // buttonShowSecret
            // 
            this.buttonShowSecret.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowSecret.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonShowSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSecret.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonShowSecret.Location = new System.Drawing.Point(247, 125);
            this.buttonShowSecret.Name = "buttonShowSecret";
            this.buttonShowSecret.Size = new System.Drawing.Size(23, 23);
            this.buttonShowSecret.TabIndex = 17;
            this.buttonShowSecret.Text = "N";
            this.buttonShowSecret.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonShowSecret.UseCompatibleTextRendering = true;
            this.buttonShowSecret.UseVisualStyleBackColor = false;
            this.buttonShowSecret.Click += new System.EventHandler(this.buttonShowSecret_Click);
            // 
            // buttonGenerateSecret
            // 
            this.buttonGenerateSecret.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGenerateSecret.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonGenerateSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateSecret.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonGenerateSecret.Location = new System.Drawing.Point(218, 125);
            this.buttonGenerateSecret.Name = "buttonGenerateSecret";
            this.buttonGenerateSecret.Size = new System.Drawing.Size(23, 23);
            this.buttonGenerateSecret.TabIndex = 18;
            this.buttonGenerateSecret.Text = "q";
            this.buttonGenerateSecret.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGenerateSecret.UseCompatibleTextRendering = true;
            this.buttonGenerateSecret.UseVisualStyleBackColor = false;
            this.buttonGenerateSecret.Click += new System.EventHandler(this.buttonGenerateSecret_Click);
            // 
            // AddSecretForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 326);
            this.Controls.Add(this.buttonGenerateSecret);
            this.Controls.Add(this.buttonShowSecret);
            this.Controls.Add(this.comboBoxStores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSecretForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till hemlighet";
            this.Load += new System.EventHandler(this.AddSecretForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxSecret;
        public System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStores;
        private System.Windows.Forms.Button buttonShowSecret;
        private System.Windows.Forms.Button buttonGenerateSecret;
    }
}