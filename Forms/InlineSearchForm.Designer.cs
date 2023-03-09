namespace Hemligheter
{
    partial class InlineSearchForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("NYLIGEN ANVÄNDA", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("FLAMINGO", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("UTVECKLARE", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test1"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("test-secret-long-name");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("asd-asd-dddd");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("test-secret-long-nametest-secret-long-nametest-secret-long-nametest-secret-long-n" +
        "ametest-secret-long-name");
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSearchPlaceholder = new System.Windows.Forms.Label();
            this.labelSearchIcon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewSearchResult = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelSearchPlaceholder);
            this.panel1.Controls.Add(this.labelSearchIcon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 3;
            // 
            // labelSearchPlaceholder
            // 
            this.labelSearchPlaceholder.AutoSize = true;
            this.labelSearchPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchPlaceholder.CausesValidation = false;
            this.labelSearchPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelSearchPlaceholder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSearchPlaceholder.Location = new System.Drawing.Point(35, 4);
            this.labelSearchPlaceholder.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchPlaceholder.Name = "labelSearchPlaceholder";
            this.labelSearchPlaceholder.Size = new System.Drawing.Size(168, 25);
            this.labelSearchPlaceholder.TabIndex = 5;
            this.labelSearchPlaceholder.Text = "Hitta en hemlighet";
            this.labelSearchPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSearchPlaceholder.Click += new System.EventHandler(this.textBoxPlaceholder_Click);
            this.labelSearchPlaceholder.Enter += new System.EventHandler(this.textBoxPlaceholder_Enter);
            // 
            // labelSearchIcon
            // 
            this.labelSearchIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSearchIcon.CausesValidation = false;
            this.labelSearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSearchIcon.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelSearchIcon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSearchIcon.Location = new System.Drawing.Point(0, 0);
            this.labelSearchIcon.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchIcon.Name = "labelSearchIcon";
            this.labelSearchIcon.Size = new System.Drawing.Size(33, 39);
            this.labelSearchIcon.TabIndex = 5;
            this.labelSearchIcon.Text = "L";
            this.labelSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSearchIcon.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Hemligheter.Properties.Resources.icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(365, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(33, 7);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(365, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // listViewSearchResult
            // 
            this.listViewSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSearchResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSearchResult.FullRowSelect = true;
            listViewGroup1.Header = "NYLIGEN ANVÄNDA";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "FLAMINGO";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "UTVECKLARE";
            listViewGroup3.Name = "listViewGroup3";
            this.listViewSearchResult.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listViewSearchResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewSearchResult.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.IndentCount = 10;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup3;
            this.listViewSearchResult.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewSearchResult.Location = new System.Drawing.Point(0, 43);
            this.listViewSearchResult.MaximumSize = new System.Drawing.Size(400, 300);
            this.listViewSearchResult.MultiSelect = false;
            this.listViewSearchResult.Name = "listViewSearchResult";
            this.listViewSearchResult.Scrollable = false;
            this.listViewSearchResult.Size = new System.Drawing.Size(397, 250);
            this.listViewSearchResult.SmallImageList = this.imageList1;
            this.listViewSearchResult.TabIndex = 2;
            this.listViewSearchResult.TileSize = new System.Drawing.Size(395, 20);
            this.listViewSearchResult.UseCompatibleStateImageBehavior = false;
            this.listViewSearchResult.View = System.Windows.Forms.View.Tile;
            this.listViewSearchResult.Visible = false;
            this.listViewSearchResult.ItemActivate += new System.EventHandler(this.listViewSearchResult_ItemActivate);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InlineSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.listViewSearchResult);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InlineSearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InlineSearchForm";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.InlineSearchForm_Activated);
            this.Deactivate += new System.EventHandler(this.InlineSearchForm_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listViewSearchResult;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelSearchPlaceholder;
        private System.Windows.Forms.Label labelSearchIcon;
    }
}