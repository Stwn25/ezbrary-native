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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btSimpanPenerbit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 356);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 402);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Nama Penerbit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 480);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 5;
            label2.Text = "Alamat Penerbit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 425);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 503);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(465, 27);
            textBox2.TabIndex = 7;
            // 
            // btSimpanPenerbit
            // 
            btSimpanPenerbit.BackColor = SystemColors.Highlight;
            btSimpanPenerbit.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanPenerbit.ForeColor = Color.White;
            btSimpanPenerbit.Location = new Point(174, 547);
            btSimpanPenerbit.Name = "btSimpanPenerbit";
            btSimpanPenerbit.Size = new Size(136, 35);
            btSimpanPenerbit.TabIndex = 8;
            btSimpanPenerbit.Text = "Simpan";
            btSimpanPenerbit.UseVisualStyleBackColor = false;
            // 
            // ucPenerbitTambahBukuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btSimpanPenerbit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ucPenerbitTambahBukuAdmin";
            Size = new Size(496, 604);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btSimpanPenerbit;
    }
}
