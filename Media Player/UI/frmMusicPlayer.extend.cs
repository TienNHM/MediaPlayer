using FontAwesome.Sharp;
using Media_Player.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Media_Player.UI
{
    public partial class frmMusicPlayer : Form
    {
        // Hàm tạo 1 button icon
        private IconButton CreateIconButton(string name, string text)
        {
            IconButton iconButton = new IconButton();
            iconButton.AutoSize = true;
            iconButton.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton.FlatAppearance.BorderSize = 0;
            iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            iconButton.ForeColor = System.Drawing.Color.White;
            iconButton.IconChar = FontAwesome.Sharp.IconChar.Star;
            iconButton.IconColor = System.Drawing.Color.White;
            iconButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton.IconSize = 32;
            iconButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconButton.Location = new System.Drawing.Point(0, 154);
            iconButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            iconButton.Name = name;
            iconButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            iconButton.Size = new System.Drawing.Size(261, 47);
            iconButton.TabIndex = 4;
            iconButton.Text = text;
            iconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton.UseVisualStyleBackColor = true;
            iconButton.Click += new System.EventHandler(this.btnFavVideos_Click);

            return iconButton;
        }

        /// <summary>
        /// Hàm tạo mới 1 Tab chứa danh sách các bài hát trong library
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private TabPage CreateTabPage(string name, string code, List<Media> data)
        {
            // Khởi tạo listBox chứa danh sách các bài hát
            ListBox listMedia = new ListBox();
            listMedia.BackColor = Color.LightBlue;
            listMedia.BorderStyle = BorderStyle.None;
            listMedia.Dock = DockStyle.Fill;
            listMedia.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            listMedia.ForeColor = Color.DarkCyan;
            listMedia.FormattingEnabled = true;
            listMedia.ItemHeight = 35;
            listMedia.Location = new Point(3, 2);
            listMedia.Margin = new Padding(3, 2, 3, 2); 
            listMedia.Name = $"ListMedia_{code}"; // Quan trọng
            listMedia.Size = new Size(784, 648);
            listMedia.TabIndex = 0;
            listMedia.SelectedIndexChanged += new System.EventHandler(listSongs_SelectedIndexChanged);
            listMedia.DataSource = data;

            // Khởi tạo 1 tab
            TabPage tabPage = new TabPage();
            tabPage.AutoScroll = true;
            tabPage.BackColor = Color.LightBlue;
            tabPage.Controls.Add(listMedia);
            tabPage.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            tabPage.ForeColor = Color.SteelBlue;
            tabPage.Location = new Point(4, 44);
            tabPage.Margin = new Padding(3, 2, 3, 2);
            tabPage.Name = $"TabLibrary_{code}"; // Quan trọng
            tabPage.Padding = new Padding(3, 2, 3, 2);
            tabPage.Size = new Size(790, 652);
            tabPage.TabIndex = 0;
            tabPage.Text = name;

            return tabPage;
        }
    }
}
