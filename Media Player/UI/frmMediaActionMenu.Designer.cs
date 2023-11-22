namespace Media_Player
{
    partial class frmMediaActionMenu
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
            this.btnAddFav = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelSelectLibrary = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.selectLibrary = new System.Windows.Forms.ComboBox();
            this.tableLayout.SuspendLayout();
            this.panelSelectLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFav
            // 
            this.btnAddFav.AutoSize = true;
            this.btnAddFav.BackColor = System.Drawing.Color.Teal;
            this.btnAddFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFav.FlatAppearance.BorderSize = 0;
            this.btnAddFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFav.ForeColor = System.Drawing.Color.White;
            this.btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnAddFav.IconColor = System.Drawing.Color.White;
            this.btnAddFav.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddFav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFav.Location = new System.Drawing.Point(3, 73);
            this.btnAddFav.Name = "btnAddFav";
            this.btnAddFav.Size = new System.Drawing.Size(507, 75);
            this.btnAddFav.TabIndex = 0;
            this.btnAddFav.Text = "Thêm vào danh sách yêu thích";
            this.btnAddFav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFav.UseVisualStyleBackColor = false;
            this.btnAddFav.Click += new System.EventHandler(this.btnAddFav_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.BackColor = System.Drawing.Color.Teal;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemove.IconColor = System.Drawing.Color.White;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(3, 260);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(507, 75);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xóa khỏi danh sách phát";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÙY CHỌN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.btnRemove, 0, 3);
            this.tableLayout.Controls.Add(this.btnAddFav, 0, 1);
            this.tableLayout.Controls.Add(this.label1, 0, 0);
            this.tableLayout.Controls.Add(this.btnCancel, 0, 4);
            this.tableLayout.Controls.Add(this.panelSelectLibrary, 0, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(5, 5);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 5;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(513, 400);
            this.tableLayout.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCancel.Location = new System.Drawing.Point(3, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(507, 55);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelSelectLibrary
            // 
            this.panelSelectLibrary.Controls.Add(this.btnOK);
            this.panelSelectLibrary.Controls.Add(this.selectLibrary);
            this.panelSelectLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelectLibrary.Location = new System.Drawing.Point(3, 154);
            this.panelSelectLibrary.Name = "panelSelectLibrary";
            this.panelSelectLibrary.Size = new System.Drawing.Size(507, 100);
            this.panelSelectLibrary.TabIndex = 5;
            this.panelSelectLibrary.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightBlue;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOK.Location = new System.Drawing.Point(0, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(507, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // selectLibrary
            // 
            this.selectLibrary.BackColor = System.Drawing.Color.DarkSlateGray;
            this.selectLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLibrary.ForeColor = System.Drawing.Color.White;
            this.selectLibrary.FormattingEnabled = true;
            this.selectLibrary.Location = new System.Drawing.Point(0, 0);
            this.selectLibrary.Margin = new System.Windows.Forms.Padding(5);
            this.selectLibrary.Name = "selectLibrary";
            this.selectLibrary.Size = new System.Drawing.Size(507, 37);
            this.selectLibrary.TabIndex = 4;
            // 
            // frmMediaActionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.Controls.Add(this.tableLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMediaActionMenu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tùy chọn";
            this.TopMost = true;
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.panelSelectLibrary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox selectLibrary;
        private System.Windows.Forms.Panel panelSelectLibrary;
        private System.Windows.Forms.Button btnOK;
        public FontAwesome.Sharp.IconButton btnRemove;
    }
}