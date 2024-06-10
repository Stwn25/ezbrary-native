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
            ((System.ComponentModel.ISupportInitialize)dgvJenisBuku).BeginInit();
            SuspendLayout();
            // 
            // btSimpanJenisBuku
            // 
            btSimpanJenisBuku.BackColor = SystemColors.Highlight;
            btSimpanJenisBuku.FlatStyle = FlatStyle.Popup;
            btSimpanJenisBuku.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanJenisBuku.ForeColor = Color.White;
            btSimpanJenisBuku.Location = new Point(153, 380);
            btSimpanJenisBuku.Margin = new Padding(3, 2, 3, 2);
            btSimpanJenisBuku.Name = "btSimpanJenisBuku";
            btSimpanJenisBuku.Size = new Size(119, 26);
            btSimpanJenisBuku.TabIndex = 14;
            btSimpanJenisBuku.Text = "Simpan";
            btSimpanJenisBuku.UseVisualStyleBackColor = false;
            btSimpanJenisBuku.Click += btSimpanJenisBuku_Click;
            // 
            // tbJenisBuku
            // 
            tbJenisBuku.BorderStyle = BorderStyle.FixedSingle;
            tbJenisBuku.Location = new Point(14, 339);
            tbJenisBuku.Margin = new Padding(3, 2, 3, 2);
            tbJenisBuku.Name = "tbJenisBuku";
            tbJenisBuku.Size = new Size(407, 23);
            tbJenisBuku.TabIndex = 12;
            tbJenisBuku.TextChanged += tbJenisBuku_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito SemiBold", 8.999998F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 322);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 10;
            label1.Text = "Tambah Jenis Buku";
            // 
            // dgvJenisBuku
            // 
            dgvJenisBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJenisBuku.BackgroundColor = SystemColors.ControlLight;
            dgvJenisBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJenisBuku.Location = new Point(14, 38);
            dgvJenisBuku.Margin = new Padding(3, 2, 3, 2);
            dgvJenisBuku.Name = "dgvJenisBuku";
            dgvJenisBuku.RowHeadersWidth = 51;
            dgvJenisBuku.Size = new Size(407, 267);
            dgvJenisBuku.TabIndex = 9;
            dgvJenisBuku.CellContentClick += dgvJenisBuku_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(381, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(40, 31);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ucJenisBukuTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(btSimpanJenisBuku);
            Controls.Add(tbJenisBuku);
            Controls.Add(label1);
            Controls.Add(dgvJenisBuku);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucJenisBukuTambahBukuAdmin";
            Size = new Size(432, 436);
            ((System.ComponentModel.ISupportInitialize)dgvJenisBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSimpanJenisBuku;
        private TextBox tbJenisBuku;
        private Label label1;
        private DataGridView dgvJenisBuku;
        private Button button1;
    }
}
