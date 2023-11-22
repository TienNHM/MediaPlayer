namespace Media_Player.UI
{
    partial class frmMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusicPlayer));
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.panelFavorite = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectLibrary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLibManager = new FontAwesome.Sharp.IconButton();
            this.btnCreateNewLibrary = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnSortDesc = new FontAwesome.Sharp.IconButton();
            this.btnSortAsc = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabLibrary = new System.Windows.Forms.TabControl();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnMediaAction = new FontAwesome.Sharp.IconButton();
            this.labeMediaName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutSidebar.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabLibrary.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.containerMain.Location = new System.Drawing.Point(0, 0);
            this.containerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerMain.Name = "containerMain";
            this.containerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // containerMain.Panel1
            // 
            this.containerMain.Panel1.Controls.Add(this.panel1);
            // 
            // containerMain.Panel2
            // 
            this.containerMain.Panel2.BackColor = System.Drawing.Color.Gray;
            this.containerMain.Panel2.Controls.Add(this.panel2);
            this.containerMain.Size = new System.Drawing.Size(1091, 807);
            this.containerMain.SplitterDistance = 704;
            this.containerMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 704);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutMain.Controls.Add(this.axWindowsMediaPlayer, 1, 0);
            this.tableLayoutMain.Controls.Add(this.splitContainerMain, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1091, 704);
            this.tableLayoutMain.TabIndex = 2;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(1100, 2);
            this.axWindowsMediaPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(253, 700);
            this.axWindowsMediaPlayer.TabIndex = 1;
            this.axWindowsMediaPlayer.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer_CurrentItemChange);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 2);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutSidebar);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(214)))), ((int)(((byte)(198)))));
            this.splitContainerMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMain.Panel2.Controls.Add(this.tabLibrary);
            this.splitContainerMain.Size = new System.Drawing.Size(1091, 700);
            this.splitContainerMain.SplitterDistance = 289;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tableLayoutSidebar
            // 
            this.tableLayoutSidebar.AutoSize = true;
            this.tableLayoutSidebar.ColumnCount = 1;
            this.tableLayoutSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutSidebar.Controls.Add(this.panelFavorite, 0, 4);
            this.tableLayoutSidebar.Controls.Add(this.panelLibrary, 0, 3);
            this.tableLayoutSidebar.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSidebar.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutSidebar.Name = "tableLayoutSidebar";
            this.tableLayoutSidebar.RowCount = 5;
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutSidebar.Size = new System.Drawing.Size(267, 680);
            this.tableLayoutSidebar.TabIndex = 6;
            // 
            // panelFavorite
            // 
            this.panelFavorite.AutoSize = true;
            this.panelFavorite.Controls.Add(this.panel3);
            this.panelFavorite.Controls.Add(this.btnLibManager);
            this.panelFavorite.Controls.Add(this.btnCreateNewLibrary);
            this.panelFavorite.Controls.Add(this.btnFavorite);
            this.panelFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFavorite.Location = new System.Drawing.Point(3, 339);
            this.panelFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelFavorite.Size = new System.Drawing.Size(261, 339);
            this.panelFavorite.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selectLibrary);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 140);
            this.panel3.TabIndex = 6;
            // 
            // selectLibrary
            // 
            this.selectLibrary.BackColor = System.Drawing.Color.Teal;
            this.selectLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLibrary.ForeColor = System.Drawing.Color.White;
            this.selectLibrary.FormattingEnabled = true;
            this.selectLibrary.Location = new System.Drawing.Point(0, 60);
            this.selectLibrary.Name = "selectLibrary";
            this.selectLibrary.Size = new System.Drawing.Size(261, 37);
            this.selectLibrary.TabIndex = 0;
            this.selectLibrary.SelectedIndexChanged += new System.EventHandler(this.selectLibrary_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.label1.Size = new System.Drawing.Size(261, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phát danh sách";
            // 
            // btnLibManager
            // 
            this.btnLibManager.AutoSize = true;
            this.btnLibManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibManager.FlatAppearance.BorderSize = 0;
            this.btnLibManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibManager.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnLibManager.ForeColor = System.Drawing.Color.White;
            this.btnLibManager.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btnLibManager.IconColor = System.Drawing.Color.White;
            this.btnLibManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibManager.IconSize = 32;
            this.btnLibManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibManager.Location = new System.Drawing.Point(0, 107);
            this.btnLibManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibManager.Name = "btnLibManager";
            this.btnLibManager.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLibManager.Size = new System.Drawing.Size(261, 47);
            this.btnLibManager.TabIndex = 7;
            this.btnLibManager.Text = "Quản lý";
            this.btnLibManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibManager.UseVisualStyleBackColor = true;
            this.btnLibManager.Click += new System.EventHandler(this.btnLibManager_Click);
            // 
            // btnCreateNewLibrary
            // 
            this.btnCreateNewLibrary.AutoSize = true;
            this.btnCreateNewLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateNewLibrary.FlatAppearance.BorderSize = 0;
            this.btnCreateNewLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewLibrary.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnCreateNewLibrary.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewLibrary.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnCreateNewLibrary.IconColor = System.Drawing.Color.White;
            this.btnCreateNewLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateNewLibrary.IconSize = 32;
            this.btnCreateNewLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNewLibrary.Location = new System.Drawing.Point(0, 60);
            this.btnCreateNewLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewLibrary.Name = "btnCreateNewLibrary";
            this.btnCreateNewLibrary.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCreateNewLibrary.Size = new System.Drawing.Size(261, 47);
            this.btnCreateNewLibrary.TabIndex = 5;
            this.btnCreateNewLibrary.Text = "Tạo mới";
            this.btnCreateNewLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateNewLibrary.UseVisualStyleBackColor = true;
            this.btnCreateNewLibrary.Click += new System.EventHandler(this.btnCreateNewLibrary_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnFavorite.IconColor = System.Drawing.Color.White;
            this.btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFavorite.IconSize = 32;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.Location = new System.Drawing.Point(0, 10);
            this.btnFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(261, 50);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "DANH SÁCH";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.AutoSize = true;
            this.panelLibrary.Controls.Add(this.btnSortDesc);
            this.panelLibrary.Controls.Add(this.btnSortAsc);
            this.panelLibrary.Controls.Add(this.btnRemove);
            this.panelLibrary.Controls.Add(this.btnAdd);
            this.panelLibrary.Controls.Add(this.btnLibrary);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrary.Location = new System.Drawing.Point(3, 77);
            this.panelLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelLibrary.Size = new System.Drawing.Size(261, 258);
            this.panelLibrary.TabIndex = 6;
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.AutoSize = true;
            this.btnSortDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortDesc.FlatAppearance.BorderSize = 0;
            this.btnSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortDesc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSortDesc.ForeColor = System.Drawing.Color.White;
            this.btnSortDesc.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
            this.btnSortDesc.IconColor = System.Drawing.Color.White;
            this.btnSortDesc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSortDesc.IconSize = 32;
            this.btnSortDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortDesc.Location = new System.Drawing.Point(0, 201);
            this.btnSortDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSortDesc.Size = new System.Drawing.Size(261, 47);
            this.btnSortDesc.TabIndex = 5;
            this.btnSortDesc.Text = "Sort Desc";
            this.btnSortDesc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.AutoSize = true;
            this.btnSortAsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortAsc.FlatAppearance.BorderSize = 0;
            this.btnSortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAsc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSortAsc.ForeColor = System.Drawing.Color.White;
            this.btnSortAsc.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUp;
            this.btnSortAsc.IconColor = System.Drawing.Color.White;
            this.btnSortAsc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSortAsc.IconSize = 32;
            this.btnSortAsc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSortAsc.Location = new System.Drawing.Point(0, 154);
            this.btnSortAsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSortAsc.Size = new System.Drawing.Size(261, 47);
            this.btnSortAsc.TabIndex = 4;
            this.btnSortAsc.Text = "Sort Asc";
            this.btnSortAsc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.IconSize = 32;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(0, 107);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(261, 47);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 60);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(261, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnLibrary.IconColor = System.Drawing.Color.White;
            this.btnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibrary.IconSize = 32;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(0, 10);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(261, 50);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "LIBRARY";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox1.Size = new System.Drawing.Size(261, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabLibrary
            // 
            this.tabLibrary.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabLibrary.Controls.Add(this.tabSongs);
            this.tabLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLibrary.ItemSize = new System.Drawing.Size(120, 40);
            this.tabLibrary.Location = new System.Drawing.Point(0, 0);
            this.tabLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLibrary.Multiline = true;
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.SelectedIndex = 0;
            this.tabLibrary.Size = new System.Drawing.Size(798, 700);
            this.tabLibrary.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabLibrary.TabIndex = 0;
            this.tabLibrary.SelectedIndexChanged += new System.EventHandler(this.tabLibrary_SelectedIndexChanged);
            // 
            // tabSongs
            // 
            this.tabSongs.AutoScroll = true;
            this.tabSongs.BackColor = System.Drawing.Color.LightBlue;
            this.tabSongs.Controls.Add(this.listSongs);
            this.tabSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSongs.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabSongs.Location = new System.Drawing.Point(4, 44);
            this.tabSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSongs.Size = new System.Drawing.Size(790, 652);
            this.tabSongs.TabIndex = 0;
            this.tabSongs.Text = "Tất cả";
            // 
            // listSongs
            // 
            this.listSongs.BackColor = System.Drawing.Color.LightBlue;
            this.listSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSongs.ForeColor = System.Drawing.Color.DarkCyan;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 35;
            this.listSongs.Location = new System.Drawing.Point(3, 2);
            this.listSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(784, 648);
            this.listSongs.TabIndex = 0;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableFooter);
            this.panel2.Controls.Add(this.labeMediaName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 99);
            this.panel2.TabIndex = 1;
            // 
            // tableFooter
            // 
            this.tableFooter.BackColor = System.Drawing.Color.Teal;
            this.tableFooter.ColumnCount = 4;
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableFooter.Controls.Add(this.btnBack, 0, 0);
            this.tableFooter.Controls.Add(this.btnPlay, 1, 0);
            this.tableFooter.Controls.Add(this.btnNext, 2, 0);
            this.tableFooter.Controls.Add(this.btnMediaAction, 3, 0);
            this.tableFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFooter.Location = new System.Drawing.Point(0, 47);
            this.tableFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableFooter.Name = "tableFooter";
            this.tableFooter.RowCount = 1;
            this.tableFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFooter.Size = new System.Drawing.Size(1091, 52);
            this.tableFooter.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.SystemColors.Control;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 32;
            this.btnBack.Location = new System.Drawing.Point(20, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.btnPlay.IconColor = System.Drawing.SystemColors.Control;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 32;
            this.btnPlay.Location = new System.Drawing.Point(292, 10);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(232, 32);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.SystemColors.Control;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 32;
            this.btnNext.Location = new System.Drawing.Point(564, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(232, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMediaAction
            // 
            this.btnMediaAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMediaAction.FlatAppearance.BorderSize = 0;
            this.btnMediaAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaAction.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            this.btnMediaAction.IconColor = System.Drawing.SystemColors.Control;
            this.btnMediaAction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMediaAction.IconSize = 32;
            this.btnMediaAction.Location = new System.Drawing.Point(836, 10);
            this.btnMediaAction.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnMediaAction.Name = "btnMediaAction";
            this.btnMediaAction.Size = new System.Drawing.Size(235, 32);
            this.btnMediaAction.TabIndex = 3;
            this.btnMediaAction.UseVisualStyleBackColor = true;
            this.btnMediaAction.Click += new System.EventHandler(this.btnMediaAction_Click);
            // 
            // labeMediaName
            // 
            this.labeMediaName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labeMediaName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeMediaName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeMediaName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labeMediaName.Location = new System.Drawing.Point(0, 0);
            this.labeMediaName.Name = "labeMediaName";
            this.labeMediaName.Size = new System.Drawing.Size(1091, 47);
            this.labeMediaName.TabIndex = 1;
            this.labeMediaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Size = new System.Drawing.Size(1091, 537);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 0;
            // 
            // frmMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 807);
            this.Controls.Add(this.containerMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutSidebar.ResumeLayout(false);
            this.tableLayoutSidebar.PerformLayout();
            this.panelFavorite.ResumeLayout(false);
            this.panelFavorite.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabLibrary.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnLibrary;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSidebar;
        private System.Windows.Forms.Panel panelLibrary;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panelFavorite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableFooter;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeMediaName;
        private FontAwesome.Sharp.IconButton btnSortDesc;
        private FontAwesome.Sharp.IconButton btnSortAsc;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnMediaAction;
        private FontAwesome.Sharp.IconButton btnCreateNewLibrary;
        private System.Windows.Forms.ComboBox selectLibrary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLibManager;
        private System.Windows.Forms.TabControl tabLibrary;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.ListBox listSongs;
    }
}