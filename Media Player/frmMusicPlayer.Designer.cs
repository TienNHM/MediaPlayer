namespace Media_Player
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
            this.btnFavVideos = new FontAwesome.Sharp.IconButton();
            this.btnFavSongs = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnSortDesc = new FontAwesome.Sharp.IconButton();
            this.btnSortAsc = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabSongVideo = new System.Windows.Forms.TabControl();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.listVideos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
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
            this.panelLibrary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSongVideo.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tabVideos.SuspendLayout();
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
            this.containerMain.Size = new System.Drawing.Size(1091, 740);
            this.containerMain.SplitterDistance = 637;
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
            this.panel1.Size = new System.Drawing.Size(1091, 637);
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
            this.tableLayoutMain.Size = new System.Drawing.Size(1091, 637);
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
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(253, 633);
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
            this.splitContainerMain.Panel2.Controls.Add(this.tabSongVideo);
            this.splitContainerMain.Size = new System.Drawing.Size(1091, 633);
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
            this.tableLayoutSidebar.Size = new System.Drawing.Size(267, 613);
            this.tableLayoutSidebar.TabIndex = 6;
            // 
            // panelFavorite
            // 
            this.panelFavorite.AutoSize = true;
            this.panelFavorite.Controls.Add(this.btnFavVideos);
            this.panelFavorite.Controls.Add(this.btnFavSongs);
            this.panelFavorite.Controls.Add(this.btnFavorite);
            this.panelFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFavorite.Location = new System.Drawing.Point(3, 339);
            this.panelFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelFavorite.Size = new System.Drawing.Size(261, 164);
            this.panelFavorite.TabIndex = 6;
            // 
            // btnFavVideos
            // 
            this.btnFavVideos.AutoSize = true;
            this.btnFavVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavVideos.FlatAppearance.BorderSize = 0;
            this.btnFavVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavVideos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnFavVideos.ForeColor = System.Drawing.Color.White;
            this.btnFavVideos.IconChar = FontAwesome.Sharp.IconChar.VideoCamera;
            this.btnFavVideos.IconColor = System.Drawing.Color.White;
            this.btnFavVideos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavVideos.IconSize = 32;
            this.btnFavVideos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavVideos.Location = new System.Drawing.Point(0, 107);
            this.btnFavVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavVideos.Name = "btnFavVideos";
            this.btnFavVideos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnFavVideos.Size = new System.Drawing.Size(261, 47);
            this.btnFavVideos.TabIndex = 4;
            this.btnFavVideos.Text = "Favorite videos";
            this.btnFavVideos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavVideos.UseVisualStyleBackColor = true;
            this.btnFavVideos.Click += new System.EventHandler(this.btnFavVideos_Click);
            // 
            // btnFavSongs
            // 
            this.btnFavSongs.AutoSize = true;
            this.btnFavSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavSongs.FlatAppearance.BorderSize = 0;
            this.btnFavSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavSongs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnFavSongs.ForeColor = System.Drawing.Color.White;
            this.btnFavSongs.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.btnFavSongs.IconColor = System.Drawing.Color.White;
            this.btnFavSongs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavSongs.IconSize = 32;
            this.btnFavSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavSongs.Location = new System.Drawing.Point(0, 60);
            this.btnFavSongs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFavSongs.Name = "btnFavSongs";
            this.btnFavSongs.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnFavSongs.Size = new System.Drawing.Size(261, 47);
            this.btnFavSongs.TabIndex = 1;
            this.btnFavSongs.Text = "Favorite songs";
            this.btnFavSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavSongs.UseVisualStyleBackColor = true;
            this.btnFavSongs.Click += new System.EventHandler(this.btnFavSongs_Click);
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
            this.btnFavorite.Text = "FAVORITE";
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
            // tabSongVideo
            // 
            this.tabSongVideo.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSongVideo.Controls.Add(this.tabSongs);
            this.tabSongVideo.Controls.Add(this.tabVideos);
            this.tabSongVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSongVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSongVideo.ItemSize = new System.Drawing.Size(120, 40);
            this.tabSongVideo.Location = new System.Drawing.Point(0, 0);
            this.tabSongVideo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSongVideo.Multiline = true;
            this.tabSongVideo.Name = "tabSongVideo";
            this.tabSongVideo.SelectedIndex = 0;
            this.tabSongVideo.Size = new System.Drawing.Size(798, 633);
            this.tabSongVideo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSongVideo.TabIndex = 0;
            this.tabSongVideo.SelectedIndexChanged += new System.EventHandler(this.tabSongVideo_SelectedIndexChanged);
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
            this.tabSongs.Size = new System.Drawing.Size(790, 585);
            this.tabSongs.TabIndex = 0;
            this.tabSongs.Text = "Songs";
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
            this.listSongs.Size = new System.Drawing.Size(784, 581);
            this.listSongs.TabIndex = 0;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // tabVideos
            // 
            this.tabVideos.AutoScroll = true;
            this.tabVideos.BackColor = System.Drawing.Color.LightBlue;
            this.tabVideos.Controls.Add(this.listVideos);
            this.tabVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVideos.ForeColor = System.Drawing.Color.SteelBlue;
            this.tabVideos.Location = new System.Drawing.Point(4, 44);
            this.tabVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVideos.Size = new System.Drawing.Size(790, 585);
            this.tabVideos.TabIndex = 1;
            this.tabVideos.Text = "Videos";
            // 
            // listVideos
            // 
            this.listVideos.BackColor = System.Drawing.Color.LightBlue;
            this.listVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVideos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVideos.ForeColor = System.Drawing.Color.DarkCyan;
            this.listVideos.FormattingEnabled = true;
            this.listVideos.ItemHeight = 35;
            this.listVideos.Location = new System.Drawing.Point(3, 2);
            this.listVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listVideos.Name = "listVideos";
            this.listVideos.Size = new System.Drawing.Size(784, 581);
            this.listVideos.TabIndex = 0;
            this.listVideos.SelectedIndexChanged += new System.EventHandler(this.listVideos_SelectedIndexChanged);
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
            this.tableFooter.ColumnCount = 3;
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFooter.Controls.Add(this.btnBack, 0, 0);
            this.tableFooter.Controls.Add(this.btnPlay, 1, 0);
            this.tableFooter.Controls.Add(this.btnNext, 2, 0);
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
            this.btnBack.Size = new System.Drawing.Size(323, 32);
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
            this.btnPlay.Location = new System.Drawing.Point(383, 10);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(323, 32);
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
            this.btnNext.Location = new System.Drawing.Point(746, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(325, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.ClientSize = new System.Drawing.Size(1091, 740);
            this.Controls.Add(this.containerMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSongVideo.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tabVideos.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnFavVideos;
        private FontAwesome.Sharp.IconButton btnFavSongs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TabControl tabSongVideo;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.TabPage tabVideos;
        private System.Windows.Forms.ListBox listVideos;
        private System.Windows.Forms.TableLayoutPanel tableFooter;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeMediaName;
        private FontAwesome.Sharp.IconButton btnSortDesc;
        private FontAwesome.Sharp.IconButton btnSortAsc;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}