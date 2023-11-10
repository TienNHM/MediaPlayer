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
            this.containerMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFavorite = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.allTabs = new MetroFramework.Controls.MetroTabControl();
            this.tabSongs = new MetroFramework.Controls.MetroTabPage();
            this.tabArtists = new MetroFramework.Controls.MetroTabPage();
            this.labelMusic = new System.Windows.Forms.Label();
            this.listSongs = new System.Windows.Forms.ListView();
            this.listArtists = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).BeginInit();
            this.containerMain.Panel1.SuspendLayout();
            this.containerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.allTabs.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tabArtists.SuspendLayout();
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer2.Panel1.Controls.Add(this.btnFavorite);
            this.splitContainer2.Panel1.Controls.Add(this.btnLibrary);
            this.splitContainer2.Panel1.Controls.Add(this.btnHome);
            this.splitContainer2.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.allTabs);
            this.splitContainer2.Panel2.Controls.Add(this.labelMusic);
            this.splitContainer2.Size = new System.Drawing.Size(1091, 537);
            this.splitContainer2.SplitterDistance = 185;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 34);
            this.txtSearch.TabIndex = 0;
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
            // btnFavorite
            // 
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnFavorite.IconColor = System.Drawing.Color.Red;
            this.btnFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFavorite.IconSize = 32;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.Location = new System.Drawing.Point(20, 145);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(145, 51);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "FAVORITE";
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnLibrary.IconColor = System.Drawing.Color.Black;
            this.btnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibrary.IconSize = 32;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(20, 94);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(145, 51);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "LIBRARY";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(20, 54);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // allTabs
            // 
            this.allTabs.Controls.Add(this.tabSongs);
            this.allTabs.Controls.Add(this.tabArtists);
            this.allTabs.CustomBackground = false;
            this.allTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTabs.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.allTabs.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.allTabs.Location = new System.Drawing.Point(0, 51);
            this.allTabs.Name = "allTabs";
            this.allTabs.SelectedIndex = 1;
            this.allTabs.Size = new System.Drawing.Size(902, 486);
            this.allTabs.Style = MetroFramework.MetroColorStyle.Blue;
            this.allTabs.StyleManager = null;
            this.allTabs.TabIndex = 0;
            this.allTabs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allTabs.Theme = MetroFramework.MetroThemeStyle.Light;
            this.allTabs.UseStyleColors = false;
            // 
            // tabSongs
            // 
            this.tabSongs.Controls.Add(this.listSongs);
            this.tabSongs.CustomBackground = false;
            this.tabSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSongs.HorizontalScrollbar = false;
            this.tabSongs.HorizontalScrollbarBarColor = true;
            this.tabSongs.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSongs.HorizontalScrollbarSize = 15;
            this.tabSongs.Location = new System.Drawing.Point(4, 39);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Size = new System.Drawing.Size(894, 443);
            this.tabSongs.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabSongs.StyleManager = null;
            this.tabSongs.TabIndex = 0;
            this.tabSongs.Text = "Songs";
            this.tabSongs.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabSongs.VerticalScrollbar = false;
            this.tabSongs.VerticalScrollbarBarColor = true;
            this.tabSongs.VerticalScrollbarHighlightOnWheel = false;
            this.tabSongs.VerticalScrollbarSize = 10;
            // 
            // tabArtists
            // 
            this.tabArtists.Controls.Add(this.listArtists);
            this.tabArtists.CustomBackground = false;
            this.tabArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArtists.HorizontalScrollbar = false;
            this.tabArtists.HorizontalScrollbarBarColor = true;
            this.tabArtists.HorizontalScrollbarHighlightOnWheel = false;
            this.tabArtists.HorizontalScrollbarSize = 15;
            this.tabArtists.Location = new System.Drawing.Point(4, 39);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Size = new System.Drawing.Size(894, 443);
            this.tabArtists.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabArtists.StyleManager = null;
            this.tabArtists.TabIndex = 1;
            this.tabArtists.Text = "Artists";
            this.tabArtists.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabArtists.VerticalScrollbar = false;
            this.tabArtists.VerticalScrollbarBarColor = true;
            this.tabArtists.VerticalScrollbarHighlightOnWheel = false;
            this.tabArtists.VerticalScrollbarSize = 10;
            // 
            // labelMusic
            // 
            this.labelMusic.BackColor = System.Drawing.Color.PaleTurquoise;
            this.labelMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMusic.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusic.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelMusic.Location = new System.Drawing.Point(0, 0);
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size(902, 51);
            this.labelMusic.TabIndex = 2;
            this.labelMusic.Text = "MUSIC";
            this.labelMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listSongs
            // 
            this.listSongs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSongs.HideSelection = false;
            this.listSongs.Location = new System.Drawing.Point(0, 0);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(894, 443);
            this.listSongs.TabIndex = 2;
            this.listSongs.UseCompatibleStateImageBehavior = false;
            // 
            // listArtists
            // 
            this.listArtists.BackColor = System.Drawing.SystemColors.Info;
            this.listArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listArtists.HideSelection = false;
            this.listArtists.Location = new System.Drawing.Point(0, 0);
            this.listArtists.Name = "listArtists";
            this.listArtists.Size = new System.Drawing.Size(894, 443);
            this.listArtists.TabIndex = 2;
            this.listArtists.UseCompatibleStateImageBehavior = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.containerMain)).EndInit();
            this.containerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.allTabs.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tabArtists.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabControl allTabs;
        private MetroFramework.Controls.MetroTabPage tabSongs;
        private MetroFramework.Controls.MetroTabPage tabArtists;
        private System.Windows.Forms.Label labelMusic;
        private System.Windows.Forms.ListView listSongs;
        private System.Windows.Forms.ListView listArtists;
    }
}