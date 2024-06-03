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
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btSimpanPenulis
            // 
            btSimpanPenulis.BackColor = SystemColors.Highlight;
            btSimpanPenulis.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanPenulis.ForeColor = Color.White;
            btSimpanPenulis.Location = new Point(175, 479);
            btSimpanPenulis.Name = "btSimpanPenulis";
            btSimpanPenulis.Size = new Size(136, 35);
            btSimpanPenulis.TabIndex = 18;
            btSimpanPenulis.Text = "Simpan";
            btSimpanPenulis.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 425);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 27);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 402);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 16;
            label1.Text = "Tambah Nama Penulis";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 356);
            dataGridView1.TabIndex = 15;
            // 
            // ucPenulisTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btSimpanPenulis);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ucPenulisTambahBukuAdmin";
            Size = new Size(499, 542);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSimpanPenulis;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
