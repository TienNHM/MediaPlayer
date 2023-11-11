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
    public partial class Form1 : Form
    {
        List<string> paths;
        public Form1()
        {
            InitializeComponent();
            paths = new List<string>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if there is a next song
            int currentIndex = listBox1.SelectedIndex;
            currentIndex = currentIndex - 1;
            if (currentIndex < 0 )
            {
                currentIndex = paths.Count - 1 ;
            }
            listBox1.SelectedIndex = currentIndex;
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Multiselect = true;

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected files
                string[] files = OpenFileDialog1.FileNames;
                // them danh sach cac file vua chon vao list paths
                paths.AddRange(files);
                // xoa tat ca file dang hien thi tren giao dien
                listBox1.Items.Clear();
                // them cac file trong list paths vao giao dien listBox
                listBox1.Items.AddRange(paths.ToArray());
                // Update the media player URL to the first song in the queue
                axWindowsMediaPlayer1.URL = paths[0];
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentIndex = listBox1.SelectedIndex;
            currentIndex = currentIndex + 1;
            if(currentIndex == paths.Count)
            {
                currentIndex = 0;
            }
            listBox1.SelectedIndex = currentIndex;
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];          
        }

        private void sortASC_Click(object sender, EventArgs e)
        {
            paths.Sort();
            // xoa tat ca file dang hien thi tren giao dien
            listBox1.Items.Clear();
            // them cac file trong list paths vao giao dien listBox
            listBox1.Items.AddRange(paths.ToArray());
            // Update the media player URL to the first song in the queue
            axWindowsMediaPlayer1.URL = paths[0];

        }

        private void sortDESC_Click(object sender, EventArgs e)
        {
            paths.Sort((a, b) => b.CompareTo(a));
            // xoa tat ca file dang hien thi tren giao dien
            listBox1.Items.Clear();
            // them cac file trong list paths vao giao dien listBox
            listBox1.Items.AddRange(paths.ToArray());
            // Update the media player URL to the first song in the queue
            axWindowsMediaPlayer1.URL = paths[0];
        }

        private void ChooseFavorite_Click(object sender, EventArgs e)
        {
            // Get the selected song from the listbox1
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string selectedSong = paths[selectedIndex];
                // Check if the song is already in the favorite listbox
                if (!listBox2.Items.Contains(selectedSong))
                {
                    // Add the song to the favorite listbox
                    listBox2.Items.Add(selectedSong);
                    
                }
                else
                {
                    // Show a message that the song is already in the favorite listbox
                    MessageBox.Show("The song is already in the favorite listbox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }
    }

}