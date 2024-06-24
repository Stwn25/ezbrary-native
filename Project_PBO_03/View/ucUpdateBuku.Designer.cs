namespace Project_PBO_03.View
{
    partial class ucUpdateBuku
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
            tbPosisiRakuc = new TextBox();
            label11 = new Label();
            tbStokBukuuc = new TextBox();
            label10 = new Label();
            tbISBNuc = new TextBox();
            label9 = new Label();
            tbTahunTerbituc = new TextBox();
            tbSinopsisBukuuc = new RichTextBox();
            tbNamaBukuuc = new TextBox();
            cbJenisBukuuc = new ComboBox();
            cbPenerbituc = new ComboBox();
            cbPenulisuc = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btUpdateBuku = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPosisiRakuc
            // 
            tbPosisiRakuc.BorderStyle = BorderStyle.FixedSingle;
            tbPosisiRakuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbPosisiRakuc.Location = new Point(499, 464);
            tbPosisiRakuc.Name = "tbPosisiRakuc";
            tbPosisiRakuc.Size = new Size(404, 28);
            tbPosisiRakuc.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(499, 432);
            label11.Name = "label11";
            label11.Size = new Size(89, 23);
            label11.TabIndex = 50;
            label11.Text = "Posisi Rak";
            // 
            // tbStokBukuuc
            // 
            tbStokBukuuc.BorderStyle = BorderStyle.FixedSingle;
            tbStokBukuuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbStokBukuuc.Location = new Point(499, 96);
            tbStokBukuuc.Name = "tbStokBukuuc";
            tbStokBukuuc.Size = new Size(404, 28);
            tbStokBukuuc.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(500, 70);
            label10.Name = "label10";
            label10.Size = new Size(91, 23);
            label10.TabIndex = 48;
            label10.Text = "Stok Buku";
            // 
            // tbISBNuc
            // 
            tbISBNuc.BorderStyle = BorderStyle.FixedSingle;
            tbISBNuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbISBNuc.Location = new Point(33, 97);
            tbISBNuc.Name = "tbISBNuc";
            tbISBNuc.Size = new Size(405, 28);
            tbISBNuc.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 71);
            label9.Name = "label9";
            label9.Size = new Size(51, 23);
            label9.TabIndex = 46;
            label9.Text = "ISBN\r\n";
            // 
            // tbTahunTerbituc
            // 
            tbTahunTerbituc.BorderStyle = BorderStyle.FixedSingle;
            tbTahunTerbituc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbTahunTerbituc.Location = new Point(33, 464);
            tbTahunTerbituc.Name = "tbTahunTerbituc";
            tbTahunTerbituc.Size = new Size(405, 28);
            tbTahunTerbituc.TabIndex = 45;
            // 
            // tbSinopsisBukuuc
            // 
            tbSinopsisBukuuc.BorderStyle = BorderStyle.FixedSingle;
            tbSinopsisBukuuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbSinopsisBukuuc.Location = new Point(32, 257);
            tbSinopsisBukuuc.Name = "tbSinopsisBukuuc";
            tbSinopsisBukuuc.Size = new Size(405, 156);
            tbSinopsisBukuuc.TabIndex = 44;
            tbSinopsisBukuuc.Text = "";
            // 
            // tbNamaBukuuc
            // 
            tbNamaBukuuc.BorderStyle = BorderStyle.FixedSingle;
            tbNamaBukuuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            tbNamaBukuuc.Location = new Point(32, 176);
            tbNamaBukuuc.Name = "tbNamaBukuuc";
            tbNamaBukuuc.Size = new Size(405, 28);
            tbNamaBukuuc.TabIndex = 43;
            tbNamaBukuuc.TextChanged += tbNamaBukuuc_TextChanged;
            // 
            // cbJenisBukuuc
            // 
            cbJenisBukuuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            cbJenisBukuuc.FormattingEnabled = true;
            cbJenisBukuuc.Location = new Point(499, 364);
            cbJenisBukuuc.Name = "cbJenisBukuuc";
            cbJenisBukuuc.Size = new Size(404, 28);
            cbJenisBukuuc.TabIndex = 42;
            // 
            // cbPenerbituc
            // 
            cbPenerbituc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            cbPenerbituc.FormattingEnabled = true;
            cbPenerbituc.Location = new Point(499, 174);
            cbPenerbituc.Name = "cbPenerbituc";
            cbPenerbituc.Size = new Size(404, 28);
            cbPenerbituc.TabIndex = 41;
            // 
            // cbPenulisuc
            // 
            cbPenulisuc.Font = new Font("Nunito SemiBold", 9F, FontStyle.Bold);
            cbPenulisuc.FormattingEnabled = true;
            cbPenulisuc.Location = new Point(499, 272);
            cbPenulisuc.Name = "cbPenulisuc";
            cbPenulisuc.Size = new Size(404, 28);
            cbPenulisuc.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(499, 336);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 39;
            label8.Text = "Jenis Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 436);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 38;
            label2.Text = "Tahun Terbit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(499, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 37;
            label3.Text = "Penerbit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(499, 244);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 36;
            label4.Text = "Penulis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 229);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 35;
            label5.Text = "Sinopsis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nunito SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 145);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 34;
            label6.Text = "Nama Buku";
            // 
            // btUpdateBuku
            // 
            btUpdateBuku.BackColor = SystemColors.HotTrack;
            btUpdateBuku.FlatStyle = FlatStyle.Popup;
            btUpdateBuku.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdateBuku.ForeColor = Color.White;
            btUpdateBuku.Location = new Point(326, 537);
            btUpdateBuku.Name = "btUpdateBuku";
            btUpdateBuku.Size = new Size(286, 56);
            btUpdateBuku.TabIndex = 52;
            btUpdateBuku.Text = "Update";
            btUpdateBuku.UseVisualStyleBackColor = false;
            btUpdateBuku.Click += btUpdateBuku_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 48);
            panel1.TabIndex = 53;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(885, 2);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 17;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ucUpdateBuku
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(btUpdateBuku);
            Controls.Add(tbPosisiRakuc);
            Controls.Add(label11);
            Controls.Add(tbStokBukuuc);
            Controls.Add(label10);
            Controls.Add(tbISBNuc);
            Controls.Add(label9);
            Controls.Add(tbTahunTerbituc);
            Controls.Add(tbSinopsisBukuuc);
            Controls.Add(tbNamaBukuuc);
            Controls.Add(cbJenisBukuuc);
            Controls.Add(cbPenerbituc);
            Controls.Add(cbPenulisuc);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "ucUpdateBuku";
            Size = new Size(942, 642);
            Load += ucUpdateBuku_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPosisiRakuc;
        private Label label11;
        private TextBox tbStokBukuuc;
        private Label label10;
        private TextBox tbISBNuc;
        private Label label9;
        private TextBox tbTahunTerbituc;
        private RichTextBox tbSinopsisBukuuc;
        private TextBox tbNamaBukuuc;
        private ComboBox cbJenisBukuuc;
        private ComboBox cbPenerbituc;
        private ComboBox cbPenulisuc;
        private Label label8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btUpdateBuku;
        private Panel panel1;
        private Button button1;
    }
}
