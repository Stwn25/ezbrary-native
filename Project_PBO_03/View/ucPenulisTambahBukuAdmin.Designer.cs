namespace Project_PBO_03
{
    partial class ucPenulisTambahBukuAdmin
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
            btSimpanPenulis = new Button();
            tbNamaPenulis = new TextBox();
            label1 = new Label();
            dgvPenulis = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPenulis).BeginInit();
            SuspendLayout();
            // 
            // btSimpanPenulis
            // 
            btSimpanPenulis.BackColor = SystemColors.Highlight;
            btSimpanPenulis.FlatStyle = FlatStyle.Popup;
            btSimpanPenulis.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanPenulis.ForeColor = Color.White;
            btSimpanPenulis.Location = new Point(175, 506);
            btSimpanPenulis.Name = "btSimpanPenulis";
            btSimpanPenulis.Size = new Size(136, 35);
            btSimpanPenulis.TabIndex = 18;
            btSimpanPenulis.Text = "Simpan";
            btSimpanPenulis.UseVisualStyleBackColor = false;
            btSimpanPenulis.Click += btSimpanPenulis_Click;
            // 
            // tbNamaPenulis
            // 
            tbNamaPenulis.BorderStyle = BorderStyle.FixedSingle;
            tbNamaPenulis.Location = new Point(16, 452);
            tbNamaPenulis.Name = "tbNamaPenulis";
            tbNamaPenulis.Size = new Size(465, 27);
            tbNamaPenulis.TabIndex = 17;
            tbNamaPenulis.TextChanged += tbNamaPenulis_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 429);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 16;
            label1.Text = "Tambah Nama Penulis";
            // 
            // dgvPenulis
            // 
            dgvPenulis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenulis.BackgroundColor = SystemColors.ControlLight;
            dgvPenulis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenulis.Location = new Point(16, 50);
            dgvPenulis.Name = "dgvPenulis";
            dgvPenulis.RowHeadersWidth = 51;
            dgvPenulis.Size = new Size(465, 356);
            dgvPenulis.TabIndex = 15;
            dgvPenulis.CellContentClick += dgvPenulis_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(435, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 19;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ucPenulisTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(btSimpanPenulis);
            Controls.Add(tbNamaPenulis);
            Controls.Add(label1);
            Controls.Add(dgvPenulis);
            Name = "ucPenulisTambahBukuAdmin";
            Size = new Size(499, 583);
            ((System.ComponentModel.ISupportInitialize)dgvPenulis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSimpanPenulis;
        private TextBox tbNamaPenulis;
        private Label label1;
        private DataGridView dgvPenulis;
        private Button button1;
    }
}
