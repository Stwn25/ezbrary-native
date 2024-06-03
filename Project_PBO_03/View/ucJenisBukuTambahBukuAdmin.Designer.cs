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
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btSimpanJenisBuku
            // 
            btSimpanJenisBuku.BackColor = SystemColors.Highlight;
            btSimpanJenisBuku.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanJenisBuku.ForeColor = Color.White;
            btSimpanJenisBuku.Location = new Point(175, 479);
            btSimpanJenisBuku.Name = "btSimpanJenisBuku";
            btSimpanJenisBuku.Size = new Size(136, 35);
            btSimpanJenisBuku.TabIndex = 14;
            btSimpanJenisBuku.Text = "Simpan";
            btSimpanJenisBuku.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 425);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 402);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 10;
            label1.Text = "Tambah Jenis Buku";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 356);
            dataGridView1.TabIndex = 9;
            // 
            // ucJenisBukuTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btSimpanJenisBuku);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ucJenisBukuTambahBukuAdmin";
            Size = new Size(494, 529);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSimpanJenisBuku;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
