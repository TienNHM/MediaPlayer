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
    public partial class frmCreateLibrary : Form
    {
        public string LibraryName { get; set; }

        public frmCreateLibrary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Trả về LibraryName cho form chính
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.LibraryName = this.txtLibName.Text.Trim();
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
