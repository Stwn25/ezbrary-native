namespace Project_PBO_03
{
    partial class ucPenerbitTambahBukuAdmin
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
            dgvPenerbit = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbNamaPenerbit = new TextBox();
            tbAlamatPenerbit = new TextBox();
            btSimpanPenerbit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPenerbit).BeginInit();
            SuspendLayout();
            // 
            // dgvPenerbit
            // 
            dgvPenerbit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenerbit.BackgroundColor = SystemColors.ControlLight;
            dgvPenerbit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenerbit.Location = new Point(18, 50);
            dgvPenerbit.Name = "dgvPenerbit";
            dgvPenerbit.RowHeadersWidth = 51;
            dgvPenerbit.Size = new Size(465, 356);
            dgvPenerbit.TabIndex = 0;
            dgvPenerbit.CellContentClick += dgvPenerbit_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 429);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Nama Penerbit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 507);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 5;
            label2.Text = "Alamat Penerbit";
            // 
            // tbNamaPenerbit
            // 
            tbNamaPenerbit.BorderStyle = BorderStyle.FixedSingle;
            tbNamaPenerbit.Location = new Point(18, 452);
            tbNamaPenerbit.Name = "tbNamaPenerbit";
            tbNamaPenerbit.Size = new Size(465, 27);
            tbNamaPenerbit.TabIndex = 6;
            tbNamaPenerbit.TextChanged += tbNamaPenerbit_TextChanged;
            // 
            // tbAlamatPenerbit
            // 
            tbAlamatPenerbit.BorderStyle = BorderStyle.FixedSingle;
            tbAlamatPenerbit.Location = new Point(18, 530);
            tbAlamatPenerbit.Name = "tbAlamatPenerbit";
            tbAlamatPenerbit.Size = new Size(465, 27);
            tbAlamatPenerbit.TabIndex = 7;
            // 
            // btSimpanPenerbit
            // 
            btSimpanPenerbit.BackColor = SystemColors.Highlight;
            btSimpanPenerbit.FlatStyle = FlatStyle.Popup;
            btSimpanPenerbit.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanPenerbit.ForeColor = Color.White;
            btSimpanPenerbit.Location = new Point(177, 574);
            btSimpanPenerbit.Name = "btSimpanPenerbit";
            btSimpanPenerbit.Size = new Size(136, 35);
            btSimpanPenerbit.TabIndex = 8;
            btSimpanPenerbit.Text = "Simpan";
            btSimpanPenerbit.UseVisualStyleBackColor = false;
            btSimpanPenerbit.Click += btSimpanPenerbit_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(437, 3);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ucPenerbitTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(btSimpanPenerbit);
            Controls.Add(tbAlamatPenerbit);
            Controls.Add(tbNamaPenerbit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPenerbit);
            Name = "ucPenerbitTambahBukuAdmin";
            Size = new Size(496, 624);
            ((System.ComponentModel.ISupportInitialize)dgvPenerbit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPenerbit;
        private Label label1;
        private Label label2;
        private TextBox tbNamaPenerbit;
        private TextBox tbAlamatPenerbit;
        private Button btSimpanPenerbit;
        private Button button1;
    }
}
