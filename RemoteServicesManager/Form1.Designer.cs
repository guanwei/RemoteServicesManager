namespace RemoteServicesManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonComputers = new System.Windows.Forms.Button();
            this.textComputers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.olvServices = new BrightIdeasSoftware.ObjectListView();
            this.computerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.displayNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.descriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.startupTypeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.logOnAsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pathColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupImageList = new System.Windows.Forms.ImageList(this.components);
            this.hotItemStyle1 = new BrightIdeasSoftware.HotItemStyle();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnResume = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnStartMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLogOn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnTXT = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnEXCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHTML = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.CanceltoolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ErrortoolStrip = new System.Windows.Forms.ToolStripLabel();
            this.MsgtoolStrip = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetStartModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetLogonAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.JumpToGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.KillServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAlertCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportToTXTMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToCSVMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToHTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.JumpToGroupMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvServices)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote Services Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Controls.Add(this.buttonComputers);
            this.groupBox1.Controls.Add(this.textComputers);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(599, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 21);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Location = new System.Drawing.Point(392, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service Name:";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textSearch.Location = new System.Drawing.Point(475, 13);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(120, 21);
            this.textSearch.TabIndex = 4;
            // 
            // buttonComputers
            // 
            this.buttonComputers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonComputers.Image = ((System.Drawing.Image)(resources.GetObject("buttonComputers.Image")));
            this.buttonComputers.Location = new System.Drawing.Point(311, 12);
            this.buttonComputers.Name = "buttonComputers";
            this.buttonComputers.Size = new System.Drawing.Size(75, 21);
            this.buttonComputers.TabIndex = 3;
            this.buttonComputers.Text = "&Import...";
            this.buttonComputers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComputers.UseVisualStyleBackColor = true;
            this.buttonComputers.Click += new System.EventHandler(this.buttonComputers_Click);
            // 
            // textComputers
            // 
            this.textComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textComputers.Location = new System.Drawing.Point(72, 13);
            this.textComputers.Name = "textComputers";
            this.textComputers.Size = new System.Drawing.Size(235, 21);
            this.textComputers.TabIndex = 1;
            this.textComputers.TextChanged += new System.EventHandler(this.textComputers_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Computers:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textFilter);
            this.groupBox2.Location = new System.Drawing.Point(700, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(7, 14);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(102, 21);
            this.textFilter.TabIndex = 4;
            this.textFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // olvServices
            // 
            this.olvServices.AllColumns.Add(this.computerColumn);
            this.olvServices.AllColumns.Add(this.nameColumn);
            this.olvServices.AllColumns.Add(this.displayNameColumn);
            this.olvServices.AllColumns.Add(this.descriptionColumn);
            this.olvServices.AllColumns.Add(this.statusColumn);
            this.olvServices.AllColumns.Add(this.startupTypeColumn);
            this.olvServices.AllColumns.Add(this.logOnAsColumn);
            this.olvServices.AllColumns.Add(this.pathColumn);
            this.olvServices.AllowColumnReorder = true;
            this.olvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvServices.BackColor = System.Drawing.SystemColors.Window;
            this.olvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.computerColumn,
            this.displayNameColumn,
            this.descriptionColumn,
            this.statusColumn,
            this.startupTypeColumn,
            this.logOnAsColumn});
            this.olvServices.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvServices.EmptyListMsg = "This service list is empty";
            this.olvServices.FullRowSelect = true;
            this.olvServices.GroupImageList = this.groupImageList;
            this.olvServices.GroupWithItemCountFormat = "{0} ({1} services)";
            this.olvServices.GroupWithItemCountSingularFormat = "{0} ({1} service)";
            this.olvServices.HideSelection = false;
            this.olvServices.HotItemStyle = this.hotItemStyle1;
            this.olvServices.IncludeColumnHeadersInCopy = true;
            this.olvServices.LargeImageList = this.largeImageList;
            this.olvServices.Location = new System.Drawing.Point(13, 103);
            this.olvServices.Name = "olvServices";
            this.olvServices.OwnerDraw = true;
            this.olvServices.OwnerDrawnHeader = true;
            this.olvServices.ShowImagesOnSubItems = true;
            this.olvServices.ShowItemCountOnGroups = true;
            this.olvServices.ShowItemToolTips = true;
            this.olvServices.Size = new System.Drawing.Size(641, 359);
            this.olvServices.SmallImageList = this.smallImageList;
            this.olvServices.TabIndex = 4;
            this.olvServices.UseAlternatingBackColors = true;
            this.olvServices.UseCompatibleStateImageBehavior = false;
            this.olvServices.UseFiltering = true;
            this.olvServices.UseHotItem = true;
            this.olvServices.View = System.Windows.Forms.View.Details;
            this.olvServices.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.olvServices_CellRightClick);
            this.olvServices.SelectedIndexChanged += new System.EventHandler(this.olvServices_SelectedIndexChanged);
            this.olvServices.KeyUp += new System.Windows.Forms.KeyEventHandler(this.olvServices_KeyUp);
            // 
            // computerColumn
            // 
            this.computerColumn.AspectName = "SystemName";
            this.computerColumn.Text = "Computer";
            this.computerColumn.Width = 140;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.DisplayIndex = 1;
            this.nameColumn.IsVisible = false;
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 80;
            // 
            // displayNameColumn
            // 
            this.displayNameColumn.AspectName = "DisplayName";
            this.displayNameColumn.Text = "DisplayName";
            this.displayNameColumn.Width = 180;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AspectName = "Description";
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.Width = 80;
            // 
            // statusColumn
            // 
            this.statusColumn.AspectName = "State";
            this.statusColumn.Text = "Status";
            // 
            // startupTypeColumn
            // 
            this.startupTypeColumn.AspectName = "StartMode";
            this.startupTypeColumn.Text = "Startup Type";
            this.startupTypeColumn.Width = 80;
            // 
            // logOnAsColumn
            // 
            this.logOnAsColumn.AspectName = "StartName";
            this.logOnAsColumn.Text = "Log On As";
            this.logOnAsColumn.Width = 80;
            // 
            // pathColumn
            // 
            this.pathColumn.AspectName = "PathName";
            this.pathColumn.DisplayIndex = 6;
            this.pathColumn.IsVisible = false;
            this.pathColumn.Text = "Path to executable";
            this.pathColumn.Width = 300;
            // 
            // groupImageList
            // 
            this.groupImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("groupImageList.ImageStream")));
            this.groupImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.groupImageList.Images.SetKeyName(0, "Computer");
            // 
            // hotItemStyle1
            // 
            this.hotItemStyle1.BackColor = System.Drawing.Color.PeachPuff;
            this.hotItemStyle1.ForeColor = System.Drawing.Color.MediumBlue;
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "started");
            this.largeImageList.Images.SetKeyName(1, "stopped");
            this.largeImageList.Images.SetKeyName(2, "paused");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "running");
            this.smallImageList.Images.SetKeyName(1, "stopped");
            this.smallImageList.Images.SetKeyName(2, "paused");
            this.smallImageList.Images.SetKeyName(3, "stopping");
            this.smallImageList.Images.SetKeyName(4, "starting");
            this.smallImageList.Images.SetKeyName(5, "resuming");
            this.smallImageList.Images.SetKeyName(6, "restarting");
            this.smallImageList.Images.SetKeyName(7, "pausing");
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Location = new System.Drawing.Point(660, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 367);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripBtnStart,
            this.toolStripBtnStop,
            this.toolStripBtnPause,
            this.toolStripBtnResume,
            this.toolStripBtnRestart,
            this.toolStripLabel3,
            this.toolStripBtnStartMode,
            this.toolStripBtnLogOn,
            this.toolStripLabel2,
            this.toolStripBtnTXT,
            this.toolStripBtnEXCEL,
            this.toolStripBtnHTML});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(151, 338);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(148, 19);
            this.toolStripLabel1.Text = "Actions";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripBtnStart
            // 
            this.toolStripBtnStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStart.Image")));
            this.toolStripBtnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStart.Name = "toolStripBtnStart";
            this.toolStripBtnStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnStart.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnStart.Text = "Start";
            this.toolStripBtnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStart.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripBtnStop
            // 
            this.toolStripBtnStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStop.Image")));
            this.toolStripBtnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStop.Name = "toolStripBtnStop";
            this.toolStripBtnStop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnStop.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnStop.Text = "Stop";
            this.toolStripBtnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStop.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripBtnPause
            // 
            this.toolStripBtnPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPause.Image")));
            this.toolStripBtnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPause.Name = "toolStripBtnPause";
            this.toolStripBtnPause.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnPause.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnPause.Text = "Pause";
            this.toolStripBtnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnPause.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripBtnResume
            // 
            this.toolStripBtnResume.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnResume.Image")));
            this.toolStripBtnResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnResume.Name = "toolStripBtnResume";
            this.toolStripBtnResume.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnResume.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnResume.Text = "Resume";
            this.toolStripBtnResume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnResume.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripBtnRestart
            // 
            this.toolStripBtnRestart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnRestart.Image")));
            this.toolStripBtnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnRestart.Name = "toolStripBtnRestart";
            this.toolStripBtnRestart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnRestart.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnRestart.Text = "Restart";
            this.toolStripBtnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnRestart.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(148, 19);
            this.toolStripLabel3.Text = "Modify...";
            this.toolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripBtnStartMode
            // 
            this.toolStripBtnStartMode.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnStartMode.Image")));
            this.toolStripBtnStartMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStartMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStartMode.Name = "toolStripBtnStartMode";
            this.toolStripBtnStartMode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnStartMode.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnStartMode.Text = "Set start mode...";
            this.toolStripBtnStartMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnStartMode.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripBtnLogOn
            // 
            this.toolStripBtnLogOn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLogOn.Image")));
            this.toolStripBtnLogOn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnLogOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLogOn.Name = "toolStripBtnLogOn";
            this.toolStripBtnLogOn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnLogOn.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnLogOn.Text = "Set logon account...";
            this.toolStripBtnLogOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnLogOn.Click += new System.EventHandler(this.toolStripBtnActions_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(148, 19);
            this.toolStripLabel2.Text = "Export";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripBtnTXT
            // 
            this.toolStripBtnTXT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnTXT.Image")));
            this.toolStripBtnTXT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnTXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnTXT.Name = "toolStripBtnTXT";
            this.toolStripBtnTXT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnTXT.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnTXT.Text = "Export to TXT...";
            this.toolStripBtnTXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnTXT.Click += new System.EventHandler(this.toolStripBtnExport_Click);
            // 
            // toolStripBtnEXCEL
            // 
            this.toolStripBtnEXCEL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEXCEL.Image")));
            this.toolStripBtnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnEXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEXCEL.Name = "toolStripBtnEXCEL";
            this.toolStripBtnEXCEL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnEXCEL.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnEXCEL.Text = "Export to EXCEL...";
            this.toolStripBtnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnEXCEL.Click += new System.EventHandler(this.toolStripBtnExport_Click);
            // 
            // toolStripBtnHTML
            // 
            this.toolStripBtnHTML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHTML.Image")));
            this.toolStripBtnHTML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnHTML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHTML.Name = "toolStripBtnHTML";
            this.toolStripBtnHTML.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.toolStripBtnHTML.Size = new System.Drawing.Size(148, 24);
            this.toolStripBtnHTML.Text = "Export to HTML...";
            this.toolStripBtnHTML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripBtnHTML.Click += new System.EventHandler(this.toolStripBtnExport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(1, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(814, 20);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanceltoolStripBtn,
            this.toolStripProgressBar1,
            this.ErrortoolStrip,
            this.MsgtoolStrip});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(1, 468);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(3, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // CanceltoolStripBtn
            // 
            this.CanceltoolStripBtn.AutoSize = false;
            this.CanceltoolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CanceltoolStripBtn.Image = global::RemoteServicesManager.Properties.Resources.Cancel1;
            this.CanceltoolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CanceltoolStripBtn.Name = "CanceltoolStripBtn";
            this.CanceltoolStripBtn.Size = new System.Drawing.Size(22, 22);
            this.CanceltoolStripBtn.Text = "Cancel";
            this.CanceltoolStripBtn.Visible = false;
            this.CanceltoolStripBtn.Click += new System.EventHandler(this.CanceltoolStripBtn_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoSize = false;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 17);
            this.toolStripProgressBar1.Visible = false;
            // 
            // ErrortoolStrip
            // 
            this.ErrortoolStrip.IsLink = true;
            this.ErrortoolStrip.Name = "ErrortoolStrip";
            this.ErrortoolStrip.Size = new System.Drawing.Size(0, 22);
            this.ErrortoolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrortoolStrip_MouseDown);
            this.ErrortoolStrip.MouseEnter += new System.EventHandler(this.ErrortoolStrip_MouseEnter);
            this.ErrortoolStrip.MouseLeave += new System.EventHandler(this.ErrortoolStrip_MouseLeave);
            // 
            // MsgtoolStrip
            // 
            this.MsgtoolStrip.Name = "MsgtoolStrip";
            this.MsgtoolStrip.Size = new System.Drawing.Size(0, 22);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartMenuItem,
            this.StopMenuItem,
            this.PauseMenuItem,
            this.ResumeMenuItem,
            this.RestartMenuItem,
            this.toolStripSeparator1,
            this.SetStartModeMenuItem,
            this.SetLogonAccountMenuItem,
            this.toolStripSeparator2,
            this.JumpToGroupMenuItem,
            this.toolStripSeparator3,
            this.CopyMenuItem,
            this.RefreshMenuItem,
            this.toolStripSeparator4,
            this.KillServiceMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 270);
            // 
            // StartMenuItem
            // 
            this.StartMenuItem.Image = global::RemoteServicesManager.Properties.Resources.Start;
            this.StartMenuItem.Name = "StartMenuItem";
            this.StartMenuItem.Size = new System.Drawing.Size(172, 22);
            this.StartMenuItem.Text = "Start";
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Image = global::RemoteServicesManager.Properties.Resources.Stop;
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(172, 22);
            this.StopMenuItem.Text = "Stop";
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Image = global::RemoteServicesManager.Properties.Resources.Suspend;
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(172, 22);
            this.PauseMenuItem.Text = "Pause";
            // 
            // ResumeMenuItem
            // 
            this.ResumeMenuItem.Image = global::RemoteServicesManager.Properties.Resources.Resume;
            this.ResumeMenuItem.Name = "ResumeMenuItem";
            this.ResumeMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ResumeMenuItem.Text = "Resume";
            // 
            // RestartMenuItem
            // 
            this.RestartMenuItem.Image = global::RemoteServicesManager.Properties.Resources.Restart;
            this.RestartMenuItem.Name = "RestartMenuItem";
            this.RestartMenuItem.Size = new System.Drawing.Size(172, 22);
            this.RestartMenuItem.Text = "Restart";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // SetStartModeMenuItem
            // 
            this.SetStartModeMenuItem.Image = global::RemoteServicesManager.Properties.Resources.SetStartMode;
            this.SetStartModeMenuItem.Name = "SetStartModeMenuItem";
            this.SetStartModeMenuItem.Size = new System.Drawing.Size(172, 22);
            this.SetStartModeMenuItem.Text = "Set start mode...";
            // 
            // SetLogonAccountMenuItem
            // 
            this.SetLogonAccountMenuItem.Image = global::RemoteServicesManager.Properties.Resources.SetLogonAccount;
            this.SetLogonAccountMenuItem.Name = "SetLogonAccountMenuItem";
            this.SetLogonAccountMenuItem.Size = new System.Drawing.Size(172, 22);
            this.SetLogonAccountMenuItem.Text = "Set logon account";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // JumpToGroupMenuItem
            // 
            this.JumpToGroupMenuItem.Name = "JumpToGroupMenuItem";
            this.JumpToGroupMenuItem.Size = new System.Drawing.Size(172, 22);
            this.JumpToGroupMenuItem.Text = "Jump to group";
            this.JumpToGroupMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.JumpToGroupMenuItem_DropDownItemClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(172, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // RefreshMenuItem
            // 
            this.RefreshMenuItem.Name = "RefreshMenuItem";
            this.RefreshMenuItem.Size = new System.Drawing.Size(172, 22);
            this.RefreshMenuItem.Text = "Refresh";
            this.RefreshMenuItem.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // KillServiceMenuItem
            // 
            this.KillServiceMenuItem.Name = "KillServiceMenuItem";
            this.KillServiceMenuItem.Size = new System.Drawing.Size(172, 22);
            this.KillServiceMenuItem.Text = "Kill Service";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAlertCopy,
            this.MenuItemClear});
            this.contextMenuStrip3.Name = "contextMenuStrip2";
            this.contextMenuStrip3.Size = new System.Drawing.Size(173, 48);
            this.contextMenuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            // 
            // MenuItemAlertCopy
            // 
            this.MenuItemAlertCopy.Name = "MenuItemAlertCopy";
            this.MenuItemAlertCopy.Size = new System.Drawing.Size(172, 22);
            this.MenuItemAlertCopy.Tag = "";
            this.MenuItemAlertCopy.Text = "Copy to Clipboard";
            // 
            // MenuItemClear
            // 
            this.MenuItemClear.Name = "MenuItemClear";
            this.MenuItemClear.Size = new System.Drawing.Size(172, 22);
            this.MenuItemClear.Tag = "";
            this.MenuItemClear.Text = "Clear Alerts";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToTXTMenuItem,
            this.ExportToCSVMenuItem,
            this.ExportToHTMLMenuItem,
            this.toolStripSeparator5,
            this.JumpToGroupMenuItem2,
            this.toolStripSeparator7,
            this.RefreshMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 126);
            // 
            // ExportToTXTMenuItem
            // 
            this.ExportToTXTMenuItem.Image = global::RemoteServicesManager.Properties.Resources.ExportToTXT;
            this.ExportToTXTMenuItem.Name = "ExportToTXTMenuItem";
            this.ExportToTXTMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ExportToTXTMenuItem.Text = "Export To TTXT...";
            // 
            // ExportToCSVMenuItem
            // 
            this.ExportToCSVMenuItem.Image = global::RemoteServicesManager.Properties.Resources.ExportToCSV;
            this.ExportToCSVMenuItem.Name = "ExportToCSVMenuItem";
            this.ExportToCSVMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ExportToCSVMenuItem.Text = "Export To CSV...";
            // 
            // ExportToHTMLMenuItem
            // 
            this.ExportToHTMLMenuItem.Image = global::RemoteServicesManager.Properties.Resources.ExportToHTML;
            this.ExportToHTMLMenuItem.Name = "ExportToHTMLMenuItem";
            this.ExportToHTMLMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ExportToHTMLMenuItem.Text = "Export to HTML...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(169, 6);
            // 
            // JumpToGroupMenuItem2
            // 
            this.JumpToGroupMenuItem2.Name = "JumpToGroupMenuItem2";
            this.JumpToGroupMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.JumpToGroupMenuItem2.Text = "Jump to group";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(169, 6);
            // 
            // RefreshMenuItem2
            // 
            this.RefreshMenuItem2.Name = "RefreshMenuItem2";
            this.RefreshMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.RefreshMenuItem2.Text = "Refresh";
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 503);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.olvServices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(846, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Services Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvServices)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonComputers;
        private System.Windows.Forms.TextBox textComputers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textFilter;
        private BrightIdeasSoftware.ObjectListView olvServices;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripBtnStart;
        private System.Windows.Forms.ToolStripButton toolStripBtnStop;
        private System.Windows.Forms.ToolStripButton toolStripBtnPause;
        private System.Windows.Forms.ToolStripButton toolStripBtnRestart;
        private System.Windows.Forms.ToolStripButton toolStripBtnStartMode;
        private System.Windows.Forms.ToolStripButton toolStripBtnLogOn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripBtnTXT;
        private System.Windows.Forms.ToolStripButton toolStripBtnEXCEL;
        private System.Windows.Forms.ToolStripButton toolStripBtnHTML;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BrightIdeasSoftware.OLVColumn computerColumn;
        private BrightIdeasSoftware.OLVColumn displayNameColumn;
        private BrightIdeasSoftware.OLVColumn descriptionColumn;
        private BrightIdeasSoftware.OLVColumn statusColumn;
        private BrightIdeasSoftware.OLVColumn startupTypeColumn;
        private BrightIdeasSoftware.OLVColumn logOnAsColumn;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn pathColumn;
        private System.Windows.Forms.ImageList groupImageList;
        private BrightIdeasSoftware.HotItemStyle hotItemStyle1;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton CanceltoolStripBtn;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripLabel MsgtoolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem JumpToGroupMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem KillServiceMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripLabel ErrortoolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAlertCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem StartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetStartModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetLogonAccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToTXTMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToCSVMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToHTMLMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem JumpToGroupMenuItem2;
        private System.Windows.Forms.ToolStripButton toolStripBtnResume;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
    }
}

