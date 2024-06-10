namespace Project_PBO_03
{
    partial class ucJenisBukuTambahBukuAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btSimpanJenisBuku = new Button();
            tbJenisBuku = new TextBox();
            label1 = new Label();
            dgvJenisBuku = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvJenisBuku).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btSimpanJenisBuku
            // 
            btSimpanJenisBuku.BackColor = SystemColors.Highlight;
            btSimpanJenisBuku.FlatStyle = FlatStyle.Popup;
            btSimpanJenisBuku.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanJenisBuku.ForeColor = Color.White;
            btSimpanJenisBuku.Location = new Point(174, 524);
            btSimpanJenisBuku.Name = "btSimpanJenisBuku";
            btSimpanJenisBuku.Size = new Size(136, 35);
            btSimpanJenisBuku.TabIndex = 14;
            btSimpanJenisBuku.Text = "Simpan";
            btSimpanJenisBuku.UseVisualStyleBackColor = false;
            btSimpanJenisBuku.Click += btSimpanJenisBuku_Click;
            // 
            // tbJenisBuku
            // 
            tbJenisBuku.BorderStyle = BorderStyle.FixedSingle;
            tbJenisBuku.Location = new Point(15, 469);
            tbJenisBuku.Name = "tbJenisBuku";
            tbJenisBuku.Size = new Size(465, 27);
            tbJenisBuku.TabIndex = 12;
            tbJenisBuku.TextChanged += tbJenisBuku_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito SemiBold", 8.999998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 446);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 10;
            label1.Text = "Tambah Jenis Buku";
            // 
            // dgvJenisBuku
            // 
            dgvJenisBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJenisBuku.BackgroundColor = SystemColors.ControlLight;
            dgvJenisBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJenisBuku.Location = new Point(15, 68);
            dgvJenisBuku.Name = "dgvJenisBuku";
            dgvJenisBuku.RowHeadersWidth = 51;
            dgvJenisBuku.Size = new Size(465, 356);
            dgvJenisBuku.TabIndex = 9;
            dgvJenisBuku.CellContentClick += dgvJenisBuku_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(435, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 50);
            panel1.TabIndex = 16;
            // 
            // ucJenisBukuTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(btSimpanJenisBuku);
            Controls.Add(tbJenisBuku);
            Controls.Add(label1);
            Controls.Add(dgvJenisBuku);
            Name = "ucJenisBukuTambahBukuAdmin";
            Size = new Size(494, 581);
            ((System.ComponentModel.ISupportInitialize)dgvJenisBuku).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSimpanJenisBuku;
        private TextBox tbJenisBuku;
        private Label label1;
        private DataGridView dgvJenisBuku;
        private Button button1;
        private Panel panel1;
    }
}
