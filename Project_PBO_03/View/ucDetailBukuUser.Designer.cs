namespace Project_PBO_03.View
{
    partial class ucDetailBukuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDetailBukuUser));
            namabuku = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbSinopsis = new TextBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            lbisbnBuku = new Label();
            lbtahunterbit = new Label();
            lbpenerbit = new Label();
            lbpenulis = new Label();
            lbstok = new Label();
            lbjenisbuku = new Label();
            lbposisirak = new Label();
            btkeluar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // namabuku
            // 
            namabuku.AutoSize = true;
            namabuku.Font = new Font("Nunito", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namabuku.Location = new Point(335, 177);
            namabuku.Name = "namabuku";
            namabuku.Size = new Size(113, 26);
            namabuku.TabIndex = 11;
            namabuku.Text = "Nama Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Favorite__1_;
            pictureBox1.Location = new Point(335, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 212);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 13;
            label2.Text = "Sinopsis :";
            // 
            // tbSinopsis
            // 
            tbSinopsis.Location = new Point(38, 246);
            tbSinopsis.Multiline = true;
            tbSinopsis.Name = "tbSinopsis";
            tbSinopsis.Size = new Size(711, 74);
            tbSinopsis.TabIndex = 14;
            tbSinopsis.Text = resources.GetString("tbSinopsis.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            label9.Location = new Point(433, 386);
            label9.Name = "label9";
            label9.Size = new Size(0, 18);
            label9.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Favorite;
            pictureBox2.Location = new Point(462, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbisbnBuku
            // 
            lbisbnBuku.AutoSize = true;
            lbisbnBuku.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbisbnBuku.Location = new Point(38, 338);
            lbisbnBuku.Name = "lbisbnBuku";
            lbisbnBuku.Size = new Size(44, 18);
            lbisbnBuku.TabIndex = 24;
            lbisbnBuku.Text = "ISBN :";
            lbisbnBuku.Click += lbisbnBuku_Click_2;
            // 
            // lbtahunterbit
            // 
            lbtahunterbit.AutoSize = true;
            lbtahunterbit.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbtahunterbit.Location = new Point(36, 365);
            lbtahunterbit.Name = "lbtahunterbit";
            lbtahunterbit.Size = new Size(90, 18);
            lbtahunterbit.TabIndex = 25;
            lbtahunterbit.Text = "Tahun Terbit : ";
            // 
            // lbpenerbit
            // 
            lbpenerbit.AutoSize = true;
            lbpenerbit.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbpenerbit.Location = new Point(38, 391);
            lbpenerbit.Name = "lbpenerbit";
            lbpenerbit.Size = new Size(64, 18);
            lbpenerbit.TabIndex = 26;
            lbpenerbit.Text = "Penerbit :";
            lbpenerbit.Click += lbpenerbit_Click;
            // 
            // lbpenulis
            // 
            lbpenulis.AutoSize = true;
            lbpenulis.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbpenulis.Location = new Point(40, 416);
            lbpenulis.Name = "lbpenulis";
            lbpenulis.Size = new Size(56, 18);
            lbpenulis.TabIndex = 27;
            lbpenulis.Text = "Penulis :";
            // 
            // lbstok
            // 
            lbstok.AutoSize = true;
            lbstok.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbstok.Location = new Point(40, 439);
            lbstok.Name = "lbstok";
            lbstok.Size = new Size(41, 18);
            lbstok.TabIndex = 28;
            lbstok.Text = "Stok :";
            // 
            // lbjenisbuku
            // 
            lbjenisbuku.AutoSize = true;
            lbjenisbuku.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbjenisbuku.Location = new Point(503, 338);
            lbjenisbuku.Name = "lbjenisbuku";
            lbjenisbuku.Size = new Size(74, 18);
            lbjenisbuku.TabIndex = 29;
            lbjenisbuku.Text = "Jenis Buku :";
            // 
            // lbposisirak
            // 
            lbposisirak.AutoSize = true;
            lbposisirak.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbposisirak.Location = new Point(503, 365);
            lbposisirak.Name = "lbposisirak";
            lbposisirak.Size = new Size(73, 18);
            lbposisirak.TabIndex = 30;
            lbposisirak.Text = "Posisi Rak :";
            // 
            // btkeluar
            // 
            btkeluar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btkeluar.Location = new Point(748, 2);
            btkeluar.Margin = new Padding(3, 2, 3, 2);
            btkeluar.Name = "btkeluar";
            btkeluar.Size = new Size(40, 31);
            btkeluar.TabIndex = 31;
            btkeluar.Text = "X";
            btkeluar.UseVisualStyleBackColor = true;
            btkeluar.Click += btkeluar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            label3.Location = new Point(38, 338);
            label3.Name = "label3";
            label3.Size = new Size(0, 18);
            label3.TabIndex = 15;
            // 
            // ucDetailBukuUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btkeluar);
            Controls.Add(lbposisirak);
            Controls.Add(lbjenisbuku);
            Controls.Add(lbstok);
            Controls.Add(lbpenulis);
            Controls.Add(lbpenerbit);
            Controls.Add(lbtahunterbit);
            Controls.Add(lbisbnBuku);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(tbSinopsis);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(namabuku);
            Name = "ucDetailBukuUser";
            Size = new Size(791, 470);
            Load += ucDetailBukuUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namabuku;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbSinopsis;
        private Label label9;
        private PictureBox pictureBox2;
        private Label lbisbnBuku;
        private Label lbtahunterbit;
        private Label lbpenerbit;
        private Label lbpenulis;
        private Label lbstok;
        private Label lbjenisbuku;
        private Label lbposisirak;
        private Button btkeluar;
        private Label label3;
    }
}
