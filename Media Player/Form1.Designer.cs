namespace Media_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.previous = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ChooseFavoirite = new System.Windows.Forms.Button();
            this.sortASC = new System.Windows.Forms.Button();
            this.sortDESC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(445, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1052, 775);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(24, 610);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(113, 52);
            this.previous.TabIndex = 3;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(169, 610);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 52);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(396, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "Choose PlayList";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(2, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 564);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 602);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PlayList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FavoriteList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(346, 564);
            this.listBox2.TabIndex = 0;
            // 
            // ChooseFavoirite
            // 
            this.ChooseFavoirite.Location = new System.Drawing.Point(396, 55);
            this.ChooseFavoirite.Name = "ChooseFavoirite";
            this.ChooseFavoirite.Size = new System.Drawing.Size(92, 47);
            this.ChooseFavoirite.TabIndex = 8;
            this.ChooseFavoirite.Text = "Choose FavoriteList";
            this.ChooseFavoirite.UseVisualStyleBackColor = true;
            this.ChooseFavoirite.Click += new System.EventHandler(this.ChooseFavorite_Click);
            // 
            // sortASC
            // 
            this.sortASC.Location = new System.Drawing.Point(396, 108);
            this.sortASC.Name = "sortASC";
            this.sortASC.Size = new System.Drawing.Size(92, 47);
            this.sortASC.TabIndex = 9;
            this.sortASC.Text = "Sort ASC";
            this.sortASC.UseVisualStyleBackColor = true;
            this.sortASC.Click += new System.EventHandler(this.sortASC_Click);
            // 
            // sortDESC
            // 
            this.sortDESC.Location = new System.Drawing.Point(396, 161);
            this.sortDESC.Name = "sortDESC";
            this.sortDESC.Size = new System.Drawing.Size(92, 53);
            this.sortDESC.TabIndex = 10;
            this.sortDESC.Text = "Sort DESC";
            this.sortDESC.UseVisualStyleBackColor = true;
            this.sortDESC.Click += new System.EventHandler(this.sortDESC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 879);
            this.Controls.Add(this.sortDESC);
            this.Controls.Add(this.sortASC);
            this.Controls.Add(this.ChooseFavoirite);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ChooseFavoirite;
        private System.Windows.Forms.Button sortASC;
        private System.Windows.Forms.Button sortDESC;
    }
}

