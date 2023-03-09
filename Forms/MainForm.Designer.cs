namespace Hemligheter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rapporteraEnBuggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelSearchPlaceholder = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelSearchIcon = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelAppIcon = new System.Windows.Forms.ToolStripLabel();
            this.loadingIndicator = new System.Windows.Forms.PictureBox();
            this.tvKeys = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripTreeLeaf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopieraKvlänkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddSecret = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelUpdateAvailable = new System.Windows.Forms.Panel();
            this.buttonInstallUpdate = new System.Windows.Forms.Button();
            this.buttonCloseUpdateNotification = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.timerCheckForUpdates = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIndicator)).BeginInit();
            this.contextMenuStripTreeLeaf.SuspendLayout();
            this.contextMenuStripTreeNode.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelUpdateAvailable.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hemligheter";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapporteraEnBuggToolStripMenuItem,
            this.toolStripSeparator1,
            this.avslutaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 74);
            // 
            // rapporteraEnBuggToolStripMenuItem
            // 
            this.rapporteraEnBuggToolStripMenuItem.Name = "rapporteraEnBuggToolStripMenuItem";
            this.rapporteraEnBuggToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.rapporteraEnBuggToolStripMenuItem.Text = "Rapportera en bugg";
            this.rapporteraEnBuggToolStripMenuItem.Click += new System.EventHandler(this.rapporteraEnBuggToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(245, 32);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.labelSearchPlaceholder);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Controls.Add(this.labelSearchIcon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(375, 54);
            this.panelTop.TabIndex = 8;
            // 
            // labelSearchPlaceholder
            // 
            this.labelSearchPlaceholder.AutoSize = true;
            this.labelSearchPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchPlaceholder.CausesValidation = false;
            this.labelSearchPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelSearchPlaceholder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSearchPlaceholder.Location = new System.Drawing.Point(42, 12);
            this.labelSearchPlaceholder.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchPlaceholder.Name = "labelSearchPlaceholder";
            this.labelSearchPlaceholder.Size = new System.Drawing.Size(172, 32);
            this.labelSearchPlaceholder.TabIndex = 4;
            this.labelSearchPlaceholder.Text = "Hitta en hemlighet";
            this.labelSearchPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSearchPlaceholder.UseCompatibleTextRendering = true;
            this.labelSearchPlaceholder.Click += new System.EventHandler(this.labelSearchPlaceholder_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSearch.Location = new System.Drawing.Point(40, 15);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(282, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Tag = "";
            this.textBoxSearch.WordWrap = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(323, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 54);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelSearchIcon
            // 
            this.labelSearchIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSearchIcon.CausesValidation = false;
            this.labelSearchIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSearchIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSearchIcon.Font = new System.Drawing.Font("Webdings", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelSearchIcon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelSearchIcon.Location = new System.Drawing.Point(0, 0);
            this.labelSearchIcon.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchIcon.Name = "labelSearchIcon";
            this.labelSearchIcon.Size = new System.Drawing.Size(36, 54);
            this.labelSearchIcon.TabIndex = 2;
            this.labelSearchIcon.Text = "L";
            this.labelSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSearchIcon.UseCompatibleTextRendering = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.btnRefresh,
            this.btnAdd,
            this.toolStripLabelAppIcon});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(375, 42);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.AutoSize = false;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.ToolTipText = "Inställningar";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.ToolTipText = "Uppdatera listan på hemligheter";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAdd.AutoSize = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.ToolTipText = "Lägg till hemlighet";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripLabelAppIcon
            // 
            this.toolStripLabelAppIcon.AutoSize = false;
            this.toolStripLabelAppIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabelAppIcon.Image = global::Hemligheter.Properties.Resources.icon;
            this.toolStripLabelAppIcon.Name = "toolStripLabelAppIcon";
            this.toolStripLabelAppIcon.Size = new System.Drawing.Size(24, 24);
            this.toolStripLabelAppIcon.ToolTipText = "Hemligheter";
            this.toolStripLabelAppIcon.Click += new System.EventHandler(this.toolStripLabelAppIcon_Click);
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.BackColor = System.Drawing.Color.White;
            this.loadingIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingIndicator.Image = ((System.Drawing.Image)(resources.GetObject("loadingIndicator.Image")));
            this.loadingIndicator.Location = new System.Drawing.Point(0, 8);
            this.loadingIndicator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.Size = new System.Drawing.Size(375, 408);
            this.loadingIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingIndicator.TabIndex = 3;
            this.loadingIndicator.TabStop = false;
            this.loadingIndicator.UseWaitCursor = true;
            // 
            // tvKeys
            // 
            this.tvKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvKeys.ImageIndex = 0;
            this.tvKeys.ImageList = this.imageList1;
            this.tvKeys.Indent = 18;
            this.tvKeys.LineColor = System.Drawing.Color.DarkGray;
            this.tvKeys.Location = new System.Drawing.Point(0, 8);
            this.tvKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvKeys.Name = "tvKeys";
            this.tvKeys.SelectedImageIndex = 0;
            this.tvKeys.Size = new System.Drawing.Size(375, 451);
            this.tvKeys.TabIndex = 9;
            this.tvKeys.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvKeys_AfterCollapse);
            this.tvKeys.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvKeys_AfterExpand);
            this.tvKeys.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvKeys_NodeMouseClick);
            this.tvKeys.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvKeys_NodeMouseDoubleClick);
            this.tvKeys.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvKeys_KeyUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder_grey_16x.png");
            this.imageList1.Images.SetKeyName(1, "FolderOpen_grey_16x.png");
            this.imageList1.Images.SetKeyName(2, "AzureKeyVault_16x.png");
            // 
            // contextMenuStripTreeLeaf
            // 
            this.contextMenuStripTreeLeaf.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTreeLeaf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopieraKvlänkToolStripMenuItem,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemDelete});
            this.contextMenuStripTreeLeaf.Name = "contextMenuStripTreeNode";
            this.contextMenuStripTreeLeaf.ShowImageMargin = false;
            this.contextMenuStripTreeLeaf.Size = new System.Drawing.Size(182, 100);
            // 
            // kopieraKvlänkToolStripMenuItem
            // 
            this.kopieraKvlänkToolStripMenuItem.Name = "kopieraKvlänkToolStripMenuItem";
            this.kopieraKvlänkToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.kopieraKvlänkToolStripMenuItem.Text = "Kopiera kv-länk";
            this.kopieraKvlänkToolStripMenuItem.Click += new System.EventHandler(this.kopieraKvlänkToolStripMenuItem_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(181, 32);
            this.toolStripMenuItemEdit.Text = "Redigera";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.toolStripMenuItemEdit_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(181, 32);
            this.toolStripMenuItemDelete.Text = "Ta bort";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // contextMenuStripTreeNode
            // 
            this.contextMenuStripTreeNode.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddSecret});
            this.contextMenuStripTreeNode.Name = "contextMenuStripTreeNode";
            this.contextMenuStripTreeNode.ShowImageMargin = false;
            this.contextMenuStripTreeNode.Size = new System.Drawing.Size(223, 36);
            // 
            // toolStripMenuItemAddSecret
            // 
            this.toolStripMenuItemAddSecret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItemAddSecret.Name = "toolStripMenuItemAddSecret";
            this.toolStripMenuItemAddSecret.Size = new System.Drawing.Size(222, 32);
            this.toolStripMenuItemAddSecret.Text = "+ Lägg till hemlighet";
            this.toolStripMenuItemAddSecret.Click += new System.EventHandler(this.toolStripMenuItemAddSecret_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.White;
            this.panelMiddle.Controls.Add(this.loadingIndicator);
            this.panelMiddle.Controls.Add(this.panelUpdateAvailable);
            this.panelMiddle.Controls.Add(this.tvKeys);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 54);
            this.panelMiddle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelMiddle.Size = new System.Drawing.Size(375, 459);
            this.panelMiddle.TabIndex = 10;
            // 
            // panelUpdateAvailable
            // 
            this.panelUpdateAvailable.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelUpdateAvailable.Controls.Add(this.buttonInstallUpdate);
            this.panelUpdateAvailable.Controls.Add(this.buttonCloseUpdateNotification);
            this.panelUpdateAvailable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpdateAvailable.Location = new System.Drawing.Point(0, 416);
            this.panelUpdateAvailable.Name = "panelUpdateAvailable";
            this.panelUpdateAvailable.Size = new System.Drawing.Size(375, 43);
            this.panelUpdateAvailable.TabIndex = 10;
            this.panelUpdateAvailable.Visible = false;
            // 
            // buttonInstallUpdate
            // 
            this.buttonInstallUpdate.AutoSize = true;
            this.buttonInstallUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonInstallUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonInstallUpdate.FlatAppearance.BorderSize = 0;
            this.buttonInstallUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstallUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstallUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonInstallUpdate.Location = new System.Drawing.Point(0, 0);
            this.buttonInstallUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInstallUpdate.Name = "buttonInstallUpdate";
            this.buttonInstallUpdate.Size = new System.Drawing.Size(321, 65);
            this.buttonInstallUpdate.TabIndex = 7;
            this.buttonInstallUpdate.TabStop = false;
            this.buttonInstallUpdate.Text = "Installera uppdatering";
            this.buttonInstallUpdate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonInstallUpdate.UseVisualStyleBackColor = true;
            this.buttonInstallUpdate.Click += new System.EventHandler(this.buttonInstallUpdate_Click);
            // 
            // buttonCloseUpdateNotification
            // 
            this.buttonCloseUpdateNotification.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseUpdateNotification.FlatAppearance.BorderSize = 0;
            this.buttonCloseUpdateNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUpdateNotification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUpdateNotification.ForeColor = System.Drawing.Color.White;
            this.buttonCloseUpdateNotification.Location = new System.Drawing.Point(323, 0);
            this.buttonCloseUpdateNotification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCloseUpdateNotification.Name = "buttonCloseUpdateNotification";
            this.buttonCloseUpdateNotification.Size = new System.Drawing.Size(52, 43);
            this.buttonCloseUpdateNotification.TabIndex = 6;
            this.buttonCloseUpdateNotification.TabStop = false;
            this.buttonCloseUpdateNotification.Text = "x";
            this.buttonCloseUpdateNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCloseUpdateNotification.UseVisualStyleBackColor = true;
            this.buttonCloseUpdateNotification.Click += new System.EventHandler(this.buttonCloseUpdateNotification_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.toolStrip1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 513);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(375, 42);
            this.panelBottom.TabIndex = 11;
            // 
            // timerCheckForUpdates
            // 
            this.timerCheckForUpdates.Enabled = true;
            this.timerCheckForUpdates.Interval = 300000;
            this.timerCheckForUpdates.Tick += new System.EventHandler(this.timerCheckForUpdates_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 555);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 154);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hemligheter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIndicator)).EndInit();
            this.contextMenuStripTreeLeaf.ResumeLayout(false);
            this.contextMenuStripTreeNode.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.panelUpdateAvailable.ResumeLayout(false);
            this.panelUpdateAvailable.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox loadingIndicator;
        private System.Windows.Forms.TreeView tvKeys;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeLeaf;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem kopieraKvlänkToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeNode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddSecret;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.Label labelSearchIcon;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelSearchPlaceholder;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAppIcon;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStripMenuItem rapporteraEnBuggToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panelUpdateAvailable;
        private System.Windows.Forms.Button buttonCloseUpdateNotification;
        private System.Windows.Forms.Button buttonInstallUpdate;
        private System.Windows.Forms.Timer timerCheckForUpdates;
    }
}

