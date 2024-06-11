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
            namabuku = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbSinopsis = new TextBox();
            label3 = new Label();
            label9 = new Label();
            pbStarKosong = new PictureBox();
            lbisbnBuku = new Label();
            lbtahunterbit = new Label();
            lbpenerbit = new Label();
            lbpenulis = new Label();
            lbstok = new Label();
            lbjenisbuku = new Label();
            lbposisirak = new Label();
            btkeluar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btBookingBuku = new Button();
            tglPengambilanBooking = new DateTimePicker();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            materialMultiLineTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pbStarKuning = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStarKosong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStarKuning).BeginInit();
            SuspendLayout();
            // 
            // namabuku
            // 
            namabuku.AutoSize = true;
            namabuku.Font = new Font("Nunito", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namabuku.Location = new Point(251, 59);
            namabuku.Name = "namabuku";
            namabuku.Size = new Size(145, 33);
            namabuku.TabIndex = 11;
            namabuku.Text = "Nama Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Favorite__1_;
            pictureBox1.Location = new Point(42, 61);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 305);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 13;
            label2.Text = "Sinopsis :";
            // 
            // tbSinopsis
            // 
            tbSinopsis.BackColor = Color.White;
            tbSinopsis.BorderStyle = BorderStyle.FixedSingle;
            tbSinopsis.Location = new Point(42, 337);
            tbSinopsis.Margin = new Padding(3, 4, 3, 4);
            tbSinopsis.Multiline = true;
            tbSinopsis.Name = "tbSinopsis";
            tbSinopsis.ReadOnly = true;
            tbSinopsis.Size = new Size(558, 97);
            tbSinopsis.TabIndex = 14;
            tbSinopsis.Text = "\r\n\r\nSinopsis";
            tbSinopsis.TextChanged += tbSinopsis_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            label3.Location = new Point(42, 487);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            label9.Location = new Point(494, 551);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 22;
            // 
            // pbStarKosong
            // 
            pbStarKosong.Cursor = Cursors.Hand;
            pbStarKosong.Image = Properties.Resources.Favorite;
            pbStarKosong.Location = new Point(212, 59);
            pbStarKosong.Margin = new Padding(3, 4, 3, 4);
            pbStarKosong.Name = "pbStarKosong";
            pbStarKosong.Size = new Size(33, 33);
            pbStarKosong.SizeMode = PictureBoxSizeMode.Zoom;
            pbStarKosong.TabIndex = 23;
            pbStarKosong.TabStop = false;
            pbStarKosong.Click += pictureBox2_Click;
            // 
            // lbisbnBuku
            // 
            lbisbnBuku.AutoSize = true;
            lbisbnBuku.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbisbnBuku.Location = new Point(212, 101);
            lbisbnBuku.Name = "lbisbnBuku";
            lbisbnBuku.Size = new Size(59, 23);
            lbisbnBuku.TabIndex = 24;
            lbisbnBuku.Text = "ISBN :";
            lbisbnBuku.Click += lbisbnBuku_Click_2;
            // 
            // lbtahunterbit
            // 
            lbtahunterbit.AutoSize = true;
            lbtahunterbit.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbtahunterbit.Location = new Point(212, 130);
            lbtahunterbit.Name = "lbtahunterbit";
            lbtahunterbit.Size = new Size(118, 23);
            lbtahunterbit.TabIndex = 25;
            lbtahunterbit.Text = "Tahun Terbit : ";
            // 
            // lbpenerbit
            // 
            lbpenerbit.AutoSize = true;
            lbpenerbit.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbpenerbit.Location = new Point(212, 159);
            lbpenerbit.Name = "lbpenerbit";
            lbpenerbit.Size = new Size(83, 23);
            lbpenerbit.TabIndex = 26;
            lbpenerbit.Text = "Penerbit :";
            lbpenerbit.Click += lbpenerbit_Click;
            // 
            // lbpenulis
            // 
            lbpenulis.AutoSize = true;
            lbpenulis.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbpenulis.Location = new Point(212, 189);
            lbpenulis.Name = "lbpenulis";
            lbpenulis.Size = new Size(75, 23);
            lbpenulis.TabIndex = 27;
            lbpenulis.Text = "Penulis :";
            // 
            // lbstok
            // 
            lbstok.AutoSize = true;
            lbstok.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbstok.Location = new Point(212, 275);
            lbstok.Name = "lbstok";
            lbstok.Size = new Size(54, 23);
            lbstok.TabIndex = 28;
            lbstok.Text = "Stok :";
            // 
            // lbjenisbuku
            // 
            lbjenisbuku.AutoSize = true;
            lbjenisbuku.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbjenisbuku.Location = new Point(212, 217);
            lbjenisbuku.Name = "lbjenisbuku";
            lbjenisbuku.Size = new Size(100, 23);
            lbjenisbuku.TabIndex = 29;
            lbjenisbuku.Text = "Jenis Buku :";
            // 
            // lbposisirak
            // 
            lbposisirak.AutoSize = true;
            lbposisirak.Font = new Font("Nunito SemiBold", 9.749998F, FontStyle.Bold);
            lbposisirak.Location = new Point(212, 246);
            lbposisirak.Name = "lbposisirak";
            lbposisirak.Size = new Size(97, 23);
            lbposisirak.TabIndex = 30;
            lbposisirak.Text = "Posisi Rak :";
            // 
            // btkeluar
            // 
            btkeluar.BackColor = Color.White;
            btkeluar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btkeluar.Location = new Point(850, 5);
            btkeluar.Name = "btkeluar";
            btkeluar.Size = new Size(46, 41);
            btkeluar.TabIndex = 31;
            btkeluar.Text = "X";
            btkeluar.UseVisualStyleBackColor = false;
            btkeluar.Click += btkeluar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(352, 452);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 151);
            flowLayoutPanel1.TabIndex = 32;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // btBookingBuku
            // 
            btBookingBuku.BackColor = SystemColors.HotTrack;
            btBookingBuku.FlatStyle = FlatStyle.Popup;
            btBookingBuku.Font = new Font("Nunito", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBookingBuku.ForeColor = Color.White;
            btBookingBuku.Location = new Point(624, 389);
            btBookingBuku.Name = "btBookingBuku";
            btBookingBuku.Size = new Size(230, 36);
            btBookingBuku.TabIndex = 33;
            btBookingBuku.Text = "Booking";
            btBookingBuku.UseVisualStyleBackColor = false;
            btBookingBuku.Click += btBookingBuku_Click;
            // 
            // tglPengambilanBooking
            // 
            tglPengambilanBooking.Location = new Point(624, 347);
            tglPengambilanBooking.Name = "tglPengambilanBooking";
            tglPengambilanBooking.Size = new Size(230, 27);
            tglPengambilanBooking.TabIndex = 34;
            tglPengambilanBooking.ValueChanged += tglPengambilanBooking_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(650, 309);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 35;
            label1.Text = "Tangal Pengambilan";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mail;
            pictureBox3.Location = new Point(42, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 450);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 37;
            label4.Text = "Beri Ulasan";
            label4.Click += label4_Click_1;
            // 
            // materialMultiLineTextBoxEdit1
            // 
            materialMultiLineTextBoxEdit1.AnimateReadOnly = false;
            materialMultiLineTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBoxEdit1.Depth = 0;
            materialMultiLineTextBoxEdit1.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialMultiLineTextBoxEdit1.HideSelection = true;
            materialMultiLineTextBoxEdit1.Location = new Point(42, 482);
            materialMultiLineTextBoxEdit1.MaxLength = 32767;
            materialMultiLineTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialMultiLineTextBoxEdit1.Name = "materialMultiLineTextBoxEdit1";
            materialMultiLineTextBoxEdit1.PasswordChar = '\0';
            materialMultiLineTextBoxEdit1.ReadOnly = false;
            materialMultiLineTextBoxEdit1.ScrollBars = ScrollBars.None;
            materialMultiLineTextBoxEdit1.SelectedText = "";
            materialMultiLineTextBoxEdit1.SelectionLength = 0;
            materialMultiLineTextBoxEdit1.SelectionStart = 0;
            materialMultiLineTextBoxEdit1.ShortcutsEnabled = true;
            materialMultiLineTextBoxEdit1.Size = new Size(245, 121);
            materialMultiLineTextBoxEdit1.TabIndex = 39;
            materialMultiLineTextBoxEdit1.TabStop = false;
            materialMultiLineTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBoxEdit1.UseSystemPasswordChar = false;
            materialMultiLineTextBoxEdit1.Click += materialMultiLineTextBoxEdit1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mail;
            pictureBox4.Location = new Point(293, 571);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 53);
            panel1.TabIndex = 41;
            // 
            // pbStarKuning
            // 
            pbStarKuning.Cursor = Cursors.Hand;
            pbStarKuning.Image = Properties.Resources.star_276049;
            pbStarKuning.Location = new Point(212, 59);
            pbStarKuning.Margin = new Padding(3, 4, 3, 4);
            pbStarKuning.Name = "pbStarKuning";
            pbStarKuning.Size = new Size(33, 33);
            pbStarKuning.SizeMode = PictureBoxSizeMode.Zoom;
            pbStarKuning.TabIndex = 42;
            pbStarKuning.TabStop = false;
            pbStarKuning.Click += pbStarKuning_Click;
            // 
            // ucDetailBukuUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pbStarKuning);
            Controls.Add(pictureBox4);
            Controls.Add(materialMultiLineTextBoxEdit1);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(tglPengambilanBooking);
            Controls.Add(btBookingBuku);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btkeluar);
            Controls.Add(lbposisirak);
            Controls.Add(lbjenisbuku);
            Controls.Add(lbstok);
            Controls.Add(lbpenulis);
            Controls.Add(lbpenerbit);
            Controls.Add(lbtahunterbit);
            Controls.Add(lbisbnBuku);
            Controls.Add(pbStarKosong);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(tbSinopsis);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(namabuku);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucDetailBukuUser";
            Size = new Size(902, 625);
            Load += ucDetailBukuUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStarKosong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStarKuning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namabuku;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbSinopsis;
        private Label label3;
        private Label label9;
        private PictureBox pbStarKosong;
        private Label lbisbnBuku;
        private Label lbtahunterbit;
        private Label lbpenerbit;
        private Label lbpenulis;
        private Label lbstok;
        private Label lbjenisbuku;
        private Label lbposisirak;
        private Button btkeluar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btBookingBuku;
        private DateTimePicker tglPengambilanBooking;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEdit1;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pbStarKuning;
    }
}
