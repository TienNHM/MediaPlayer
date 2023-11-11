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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listVideos = new System.Windows.Forms.ListBox();
            this.labelMusic = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.Panel2.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerMain
            // 
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.containerMain.Panel2.Controls.Add(this.axWindowsMediaPlayer);
            this.containerMain.Size = new System.Drawing.Size(1091, 740);
            this.containerMain.SplitterDistance = 537;
            this.containerMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 537);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Panel2.Controls.Add(this.labelMusic);
            this.splitContainer2.Size = new System.Drawing.Size(1091, 537);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 517);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelFavorite
            // 
            this.panelFavorite.AutoSize = true;
            this.panelFavorite.Controls.Add(this.btnFavVideos);
            this.panelFavorite.Controls.Add(this.btnFavSongs);
            this.panelFavorite.Controls.Add(this.btnFavorite);
            this.panelFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFavorite.Location = new System.Drawing.Point(3, 297);
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
            this.panelLibrary.Controls.Add(this.btnAddVideo);
            this.panelLibrary.Controls.Add(this.btnAddMusic);
            this.panelLibrary.Controls.Add(this.btnLibrary);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrary.Location = new System.Drawing.Point(3, 144);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelLibrary.Size = new System.Drawing.Size(159, 147);
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
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
            this.tabSongVideo.Controls.Add(this.tabPage1);
            this.tabSongVideo.Controls.Add(this.tabPage2);
            this.tabSongVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSongVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSongVideo.Location = new System.Drawing.Point(0, 74);
            this.tabSongVideo.Name = "tabSongVideo";
            this.tabSongVideo.SelectedIndex = 0;
            this.tabSongVideo.Size = new System.Drawing.Size(902, 463);
            this.tabSongVideo.TabIndex = 0;
            this.tabSongVideo.SelectedIndexChanged += new System.EventHandler(this.tabSongVideo_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listSongs);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listSongs
            // 
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 29;
            this.listSongs.Location = new System.Drawing.Point(3, 3);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(888, 415);
            this.listSongs.TabIndex = 0;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listVideos);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(894, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Videos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listVideos
            // 
            this.listVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVideos.FormattingEnabled = true;
            this.listVideos.ItemHeight = 29;
            this.listVideos.Location = new System.Drawing.Point(3, 3);
            this.listVideos.Name = "listVideos";
            this.listVideos.Size = new System.Drawing.Size(888, 415);
            this.listVideos.TabIndex = 0;
            this.listVideos.SelectedIndexChanged += new System.EventHandler(this.listVideos_SelectedIndexChanged);
            // 
            // labelMusic
            // 
            this.labelMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(145)))), ((int)(((byte)(151)))));
            this.labelMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMusic.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.ForeColor = System.Drawing.Color.White;
            this.labelMusic.Location = new System.Drawing.Point(0, 0);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(902, 74);
            this.labelMusic.TabIndex = 2;
            this.labelMusic.Text = "MUSIC";
            this.labelMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(1091, 199);
            this.axWindowsMediaPlayer.TabIndex = 1;
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
            this.Name = "frmMusicPlayer";
            this.Text = "Music Player";
            this.containerMain.Panel1.ResumeLayout(false);
            this.containerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
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
        private System.Windows.Forms.Label labelMusic;
        private System.Windows.Forms.TabControl tabSongVideo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listSongs;
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
        private System.Windows.Forms.ListBox listVideos;
    }
}