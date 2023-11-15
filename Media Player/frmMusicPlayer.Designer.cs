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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelFavorite = new System.Windows.Forms.Panel();
            this.btnFavVideos = new FontAwesome.Sharp.IconButton();
            this.btnFavSongs = new FontAwesome.Sharp.IconButton();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnAddVideo = new FontAwesome.Sharp.IconButton();
            this.btnAddMusic = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabSongVideo = new System.Windows.Forms.TabControl();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.tabVideos = new System.Windows.Forms.TabPage();
            this.listVideos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.labeMediaName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSortAsc = new FontAwesome.Sharp.IconButton();
            this.btnSortDesc = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSongVideo.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tabVideos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.containerMain.Location = new System.Drawing.Point(0, 0);
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
            this.containerMain.SplitterDistance = 636;
            this.containerMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 636);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.axWindowsMediaPlayer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1091, 636);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(1100, 3);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(253, 630);
            this.axWindowsMediaPlayer.TabIndex = 1;
            this.axWindowsMediaPlayer.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer_CurrentItemChange);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(72)))), ((int)(((byte)(107)))));
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(214)))), ((int)(((byte)(198)))));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.tabSongVideo);
            this.splitContainer2.Size = new System.Drawing.Size(1091, 630);
            this.splitContainer2.SplitterDistance = 185;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panelFavorite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panelLibrary, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelHome, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 610);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelFavorite
            // 
            this.panelFavorite.AutoSize = true;
            this.panelFavorite.Controls.Add(this.btnFavVideos);
            this.panelFavorite.Controls.Add(this.btnFavSongs);
            this.panelFavorite.Controls.Add(this.btnFavorite);
            this.panelFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFavorite.Location = new System.Drawing.Point(3, 373);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelFavorite.Size = new System.Drawing.Size(159, 147);
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
            this.btnFavVideos.Location = new System.Drawing.Point(0, 99);
            this.btnFavVideos.Name = "btnFavVideos";
            this.btnFavVideos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFavVideos.Size = new System.Drawing.Size(159, 38);
            this.btnFavVideos.TabIndex = 4;
            this.btnFavVideos.Text = "Favorite videos";
            this.btnFavVideos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavVideos.UseVisualStyleBackColor = true;
            this.btnFavVideos.Visible = false;
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
            this.btnFavSongs.Location = new System.Drawing.Point(0, 61);
            this.btnFavSongs.Name = "btnFavSongs";
            this.btnFavSongs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFavSongs.Size = new System.Drawing.Size(159, 38);
            this.btnFavSongs.TabIndex = 1;
            this.btnFavSongs.Text = "Favorite songs";
            this.btnFavSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavSongs.UseVisualStyleBackColor = true;
            this.btnFavSongs.Visible = false;
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
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(159, 51);
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
            this.panelLibrary.Controls.Add(this.btnAddVideo);
            this.panelLibrary.Controls.Add(this.btnAddMusic);
            this.panelLibrary.Controls.Add(this.btnLibrary);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrary.Location = new System.Drawing.Point(3, 144);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelLibrary.Size = new System.Drawing.Size(159, 223);
            this.panelLibrary.TabIndex = 6;
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.AutoSize = true;
            this.btnAddVideo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddVideo.FlatAppearance.BorderSize = 0;
            this.btnAddVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVideo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAddVideo.ForeColor = System.Drawing.Color.White;
            this.btnAddVideo.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddVideo.IconColor = System.Drawing.Color.White;
            this.btnAddVideo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddVideo.IconSize = 32;
            this.btnAddVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVideo.Location = new System.Drawing.Point(0, 99);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddVideo.Size = new System.Drawing.Size(159, 38);
            this.btnAddVideo.TabIndex = 3;
            this.btnAddVideo.Text = "Add video";
            this.btnAddVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Visible = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.AutoSize = true;
            this.btnAddMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMusic.FlatAppearance.BorderSize = 0;
            this.btnAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMusic.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnAddMusic.ForeColor = System.Drawing.Color.White;
            this.btnAddMusic.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddMusic.IconColor = System.Drawing.Color.White;
            this.btnAddMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMusic.IconSize = 32;
            this.btnAddMusic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMusic.Location = new System.Drawing.Point(0, 61);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddMusic.Size = new System.Drawing.Size(159, 38);
            this.btnAddMusic.TabIndex = 1;
            this.btnAddMusic.Text = "Add music";
            this.btnAddMusic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Visible = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
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
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(159, 51);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "LIBRARY";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(3, 80);
            this.panelHome.Name = "panelHome";
            this.panelHome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelHome.Size = new System.Drawing.Size(159, 58);
            this.panelHome.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(159, 38);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(159, 71);
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
            this.txtSearch.Location = new System.Drawing.Point(10, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 34);
            this.txtSearch.TabIndex = 0;
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
            this.tabSongVideo.Multiline = true;
            this.tabSongVideo.Name = "tabSongVideo";
            this.tabSongVideo.SelectedIndex = 0;
            this.tabSongVideo.Size = new System.Drawing.Size(902, 630);
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
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSongs.Size = new System.Drawing.Size(894, 582);
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
            this.listSongs.HorizontalScrollbar = true;
            this.listSongs.ItemHeight = 35;
            this.listSongs.Location = new System.Drawing.Point(3, 3);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(888, 576);
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
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideos.Size = new System.Drawing.Size(894, 582);
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
            this.listVideos.HorizontalScrollbar = true;
            this.listVideos.ItemHeight = 35;
            this.listVideos.Location = new System.Drawing.Point(3, 3);
            this.listVideos.Name = "listVideos";
            this.listVideos.Size = new System.Drawing.Size(888, 576);
            this.listVideos.TabIndex = 0;
            this.listVideos.SelectedIndexChanged += new System.EventHandler(this.listVideos_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.labeMediaName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 100);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPlay, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNext, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1091, 53);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.btnBack.Size = new System.Drawing.Size(323, 33);
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
            this.btnPlay.Size = new System.Drawing.Size(323, 33);
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
            this.btnNext.Size = new System.Drawing.Size(325, 33);
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
            this.btnSortAsc.Location = new System.Drawing.Point(0, 137);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSortAsc.Size = new System.Drawing.Size(159, 38);
            this.btnSortAsc.TabIndex = 4;
            this.btnSortAsc.Text = "Sort Asc";
            this.btnSortAsc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Visible = false;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
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
            this.btnSortDesc.Location = new System.Drawing.Point(0, 175);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSortDesc.Size = new System.Drawing.Size(159, 38);
            this.btnSortDesc.TabIndex = 5;
            this.btnSortDesc.Text = "Sort Desc";
            this.btnSortDesc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Visible = false;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
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
            this.Name = "frmMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelFavorite.ResumeLayout(false);
            this.panelFavorite.PerformLayout();
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSongVideo.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tabVideos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer containerMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLibrary;
        private FontAwesome.Sharp.IconButton btnFavorite;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelLibrary;
        private FontAwesome.Sharp.IconButton btnAddMusic;
        private System.Windows.Forms.Panel panelFavorite;
        private FontAwesome.Sharp.IconButton btnFavVideos;
        private FontAwesome.Sharp.IconButton btnFavSongs;
        private FontAwesome.Sharp.IconButton btnAddVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl tabSongVideo;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.TabPage tabVideos;
        private System.Windows.Forms.ListBox listVideos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnBack;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnNext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeMediaName;
        private FontAwesome.Sharp.IconButton btnSortDesc;
        private FontAwesome.Sharp.IconButton btnSortAsc;
    }
}