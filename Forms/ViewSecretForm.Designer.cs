namespace Hemligheter
{
    partial class ViewSecretForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSecretForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonOpenSecret = new System.Windows.Forms.Button();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUpdated = new System.Windows.Forms.Label();
            this.buttonOpenUrl = new System.Windows.Forms.Button();
            this.buttonShowSecret = new System.Windows.Forms.Button();
            this.textBoxSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(21, 46);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(383, 30);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "placeholder-text";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 22);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 23);
            this.label.TabIndex = 3;
            this.label.Text = "Namn";
            // 
            // buttonOpenSecret
            // 
            this.buttonOpenSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenSecret.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonOpenSecret.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonOpenSecret.FlatAppearance.BorderSize = 0;
            this.buttonOpenSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSecret.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenSecret.ForeColor = System.Drawing.Color.White;
            this.buttonOpenSecret.Location = new System.Drawing.Point(21, 363);
            this.buttonOpenSecret.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenSecret.Name = "buttonOpenSecret";
            this.buttonOpenSecret.Size = new System.Drawing.Size(384, 55);
            this.buttonOpenSecret.TabIndex = 4;
            this.buttonOpenSecret.Text = "Kopiera hemlighet";
            this.buttonOpenSecret.UseVisualStyleBackColor = false;
            this.buttonOpenSecret.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.BackColor = System.Drawing.Color.White;
            this.textBoxAccount.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccount.Location = new System.Drawing.Point(21, 192);
            this.textBoxAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.ReadOnly = true;
            this.textBoxAccount.Size = new System.Drawing.Size(382, 30);
            this.textBoxAccount.TabIndex = 0;
            this.textBoxAccount.Text = "placeholder-text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Konto / användarnamn";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.White;
            this.textBoxUrl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(21, 266);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.ReadOnly = true;
            this.textBoxUrl.Size = new System.Drawing.Size(340, 30);
            this.textBoxUrl.TabIndex = 2;
            this.textBoxUrl.Text = "placeholder-text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senast uppdaterad:";
            // 
            // labelUpdated
            // 
            this.labelUpdated.AutoSize = true;
            this.labelUpdated.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdated.Location = new System.Drawing.Point(220, 322);
            this.labelUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdated.Name = "labelUpdated";
            this.labelUpdated.Size = new System.Drawing.Size(141, 23);
            this.labelUpdated.TabIndex = 14;
            this.labelUpdated.Text = "2019-01-01 14:30";
            // 
            // buttonOpenUrl
            // 
            this.buttonOpenUrl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOpenUrl.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOpenUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenUrl.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonOpenUrl.Location = new System.Drawing.Point(370, 266);
            this.buttonOpenUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenUrl.Name = "buttonOpenUrl";
            this.buttonOpenUrl.Size = new System.Drawing.Size(34, 35);
            this.buttonOpenUrl.TabIndex = 3;
            this.buttonOpenUrl.Text = "2";
            this.buttonOpenUrl.UseCompatibleTextRendering = true;
            this.buttonOpenUrl.UseVisualStyleBackColor = false;
            this.buttonOpenUrl.Click += new System.EventHandler(this.buttonOpenUrl_Click);
            // 
            // buttonShowSecret
            // 
            this.buttonShowSecret.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowSecret.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonShowSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSecret.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonShowSecret.Location = new System.Drawing.Point(370, 118);
            this.buttonShowSecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowSecret.Name = "buttonShowSecret";
            this.buttonShowSecret.Size = new System.Drawing.Size(34, 35);
            this.buttonShowSecret.TabIndex = 20;
            this.buttonShowSecret.Text = "N";
            this.buttonShowSecret.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonShowSecret.UseCompatibleTextRendering = true;
            this.buttonShowSecret.UseVisualStyleBackColor = false;
            this.buttonShowSecret.Click += new System.EventHandler(this.buttonShowSecret_Click);
            // 
            // textBoxSecret
            // 
            this.textBoxSecret.BackColor = System.Drawing.Color.White;
            this.textBoxSecret.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecret.Location = new System.Drawing.Point(21, 118);
            this.textBoxSecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSecret.Name = "textBoxSecret";
            this.textBoxSecret.ReadOnly = true;
            this.textBoxSecret.Size = new System.Drawing.Size(340, 30);
            this.textBoxSecret.TabIndex = 18;
            this.textBoxSecret.Text = "hemligthemligthemligt";
            this.textBoxSecret.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hemlighet";
            // 
            // ViewSecretForm
            // 
            this.AcceptButton = this.buttonOpenSecret;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 437);
            this.Controls.Add(this.buttonShowSecret);
            this.Controls.Add(this.textBoxSecret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenUrl);
            this.Controls.Add(this.labelUpdated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOpenSecret);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSecretForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visa hemlighet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonOpenSecret;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUpdated;
        private System.Windows.Forms.Button buttonOpenUrl;
        private System.Windows.Forms.Button buttonShowSecret;
        public System.Windows.Forms.TextBox textBoxSecret;
        private System.Windows.Forms.Label label3;
    }
}