using Media_Player.Contants;
using Media_Player.Data;
using Media_Player.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class frmMediaActionMenu : Form
    {
        private LinkedList<Library> libraries;
        public LinkedList<Library> AllLibraries
        {
            get => this.libraries;
            set {
                this.libraries = value;
                this.selectLibrary.DataSource = value.ToList();
            }
        }
        public Media SelectedMedia { get; set; }

        private bool isShowSelectLibrary = false;
        private LibraryInfoDB _libraryInfoDB { get; set; }

        public MediaAction SelectedAction { get; set; }
        public frmMediaActionMenu()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this._libraryInfoDB = new LibraryInfoDB();
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            this.isShowSelectLibrary = !this.isShowSelectLibrary;
            this.panelSelectLibrary.Visible = this.isShowSelectLibrary;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var library = this.selectLibrary.SelectedItem as Library;

            LibraryInfo libraryInfo = new LibraryInfo()
            {
                LibraryCode = library.Code,
                MediaCode = SelectedMedia.Code,
                Status = Status.Active
            };
            
            _libraryInfoDB.Create(libraryInfo);

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public enum MediaAction
    {
        AddToFavorite,
        RemoveMedia
    }
}
