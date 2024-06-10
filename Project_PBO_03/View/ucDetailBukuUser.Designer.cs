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
            namabuku.Location = new Point(383, 236);
            namabuku.Name = "namabuku";
            namabuku.Size = new Size(145, 33);
            namabuku.TabIndex = 11;
            namabuku.Text = "Nama Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Favorite__1_;
            pictureBox1.Location = new Point(383, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 283);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 13;
            label2.Text = "Sinopsis :";
            // 
            // tbSinopsis
            // 
            tbSinopsis.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSinopsis.Location = new Point(43, 328);
            tbSinopsis.Margin = new Padding(3, 4, 3, 4);
            tbSinopsis.Multiline = true;
            tbSinopsis.Name = "tbSinopsis";
            tbSinopsis.Size = new Size(812, 97);
            tbSinopsis.TabIndex = 14;
            tbSinopsis.Text = resources.GetString("tbSinopsis.Text");
            tbSinopsis.TextChanged += tbSinopsis_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Favorite;
            pictureBox2.Location = new Point(528, 188);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbisbnBuku
            // 
            lbisbnBuku.AutoSize = true;
            lbisbnBuku.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbisbnBuku.Location = new Point(43, 451);
            lbisbnBuku.Name = "lbisbnBuku";
            lbisbnBuku.Size = new Size(60, 23);
            lbisbnBuku.TabIndex = 24;
            lbisbnBuku.Text = "ISBN :";
            lbisbnBuku.Click += lbisbnBuku_Click_2;
            // 
            // lbtahunterbit
            // 
            lbtahunterbit.AutoSize = true;
            lbtahunterbit.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbtahunterbit.Location = new Point(41, 487);
            lbtahunterbit.Name = "lbtahunterbit";
            lbtahunterbit.Size = new Size(125, 23);
            lbtahunterbit.TabIndex = 25;
            lbtahunterbit.Text = "Tahun Terbit : ";
            // 
            // lbpenerbit
            // 
            lbpenerbit.AutoSize = true;
            lbpenerbit.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbpenerbit.Location = new Point(43, 521);
            lbpenerbit.Name = "lbpenerbit";
            lbpenerbit.Size = new Size(86, 23);
            lbpenerbit.TabIndex = 26;
            lbpenerbit.Text = "Penerbit :";
            lbpenerbit.Click += lbpenerbit_Click;
            // 
            // lbpenulis
            // 
            lbpenulis.AutoSize = true;
            lbpenulis.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbpenulis.Location = new Point(46, 555);
            lbpenulis.Name = "lbpenulis";
            lbpenulis.Size = new Size(76, 23);
            lbpenulis.TabIndex = 27;
            lbpenulis.Text = "Penulis :";
            // 
            // lbstok
            // 
            lbstok.AutoSize = true;
            lbstok.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbstok.Location = new Point(46, 585);
            lbstok.Name = "lbstok";
            lbstok.Size = new Size(56, 23);
            lbstok.TabIndex = 28;
            lbstok.Text = "Stok :";
            // 
            // lbjenisbuku
            // 
            lbjenisbuku.AutoSize = true;
            lbjenisbuku.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbjenisbuku.Location = new Point(575, 451);
            lbjenisbuku.Name = "lbjenisbuku";
            lbjenisbuku.Size = new Size(102, 23);
            lbjenisbuku.TabIndex = 29;
            lbjenisbuku.Text = "Jenis Buku :";
            // 
            // lbposisirak
            // 
            lbposisirak.AutoSize = true;
            lbposisirak.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            lbposisirak.Location = new Point(575, 487);
            lbposisirak.Name = "lbposisirak";
            lbposisirak.Size = new Size(99, 23);
            lbposisirak.TabIndex = 30;
            lbposisirak.Text = "Posisi Rak :";
            // 
            // btkeluar
            // 
            btkeluar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btkeluar.Location = new Point(855, 3);
            btkeluar.Name = "btkeluar";
            btkeluar.Size = new Size(46, 41);
            btkeluar.TabIndex = 31;
            btkeluar.Text = "X";
            btkeluar.UseVisualStyleBackColor = true;
            btkeluar.Click += btkeluar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito", 10.2F, FontStyle.Bold);
            label3.Location = new Point(43, 451);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 15;
            // 
            // ucDetailBukuUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btkeluar);
            Controls.Add(lbposisirak);
            Controls.Add(lbjenisbuku);
            Controls.Add(lbstok);
            Controls.Add(lbpenulis);
            Controls.Add(lbpenerbit);
            Controls.Add(lbtahunterbit);
            Controls.Add(lbisbnBuku);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(tbSinopsis);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(namabuku);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucDetailBukuUser";
            Size = new Size(902, 625);
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
