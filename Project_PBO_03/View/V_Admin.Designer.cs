
namespace Project_PBO_03
{
    partial class V_Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Admin));
            pnlAdmin = new Panel();
            pnlTambahBuku = new Panel();
            btKeluarAdmin = new Button();
            btProfileAdmin = new Button();
            btRiwayatPeminjaman = new Button();
            btPeminjaman = new Button();
            btKelolaBuku = new Button();
            lblGmail = new Label();
            lblUsername = new Label();
            pictureBoxVektoradmin = new PictureBox();
            pictureBoxPerpusAdmin = new PictureBox();
            lblhaiAdmin = new Label();
            lblhai1Admin = new Label();
            lblDaftarBuku = new Label();
            tbDaftarBukuAdmin = new TextBox();
            pnlDaftarBukuAdmin = new Panel();
            dgvKelolaBukuAdmin = new DataGridView();
            pnlPeminjamanAdmin = new Panel();
            dataGridView1 = new DataGridView();
            lblBookingAdmin = new Label();
            pnlRiwayatPeminjaman = new Panel();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            pnlProfileAdmin = new Panel();
            lblPasswordProfileAdmin = new Label();
            btPasswordProfileAdmin = new TextBox();
            lblNoteleponProfileAdmin = new Label();
            tbNoTeleponProfileAdmin = new TextBox();
            lblEmailProfileAdmin = new Label();
            tbEmailProfileAdmin = new TextBox();
            lblNamaProfileAdmin = new Label();
            tbNamaProfileAdmin = new TextBox();
            lblUsernameProfileAdmin = new Label();
            tbUsernameAdmin = new TextBox();
            lblProfileAdmin = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVektoradmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerpusAdmin).BeginInit();
            pnlDaftarBukuAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBukuAdmin).BeginInit();
            pnlPeminjamanAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlRiwayatPeminjaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            pnlProfileAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = SystemColors.Highlight;
            pnlAdmin.Controls.Add(pnlTambahBuku);
            pnlAdmin.Controls.Add(btKeluarAdmin);
            pnlAdmin.Controls.Add(btProfileAdmin);
            pnlAdmin.Controls.Add(btRiwayatPeminjaman);
            pnlAdmin.Controls.Add(btPeminjaman);
            pnlAdmin.Controls.Add(btKelolaBuku);
            pnlAdmin.Controls.Add(lblGmail);
            pnlAdmin.Controls.Add(lblUsername);
            pnlAdmin.Dock = DockStyle.Left;
            pnlAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlAdmin.Location = new Point(0, 0);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(416, 1080);
            pnlAdmin.TabIndex = 0;
            // 
            // pnlTambahBuku
            // 
            pnlTambahBuku.Location = new Point(418, 277);
            pnlTambahBuku.Name = "pnlTambahBuku";
            pnlTambahBuku.Size = new Size(1507, 805);
            pnlTambahBuku.TabIndex = 6;
            // 
            // btKeluarAdmin
            // 
            btKeluarAdmin.BackColor = SystemColors.HotTrack;
            btKeluarAdmin.FlatStyle = FlatStyle.Popup;
            btKeluarAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btKeluarAdmin.ForeColor = Color.White;
            btKeluarAdmin.Location = new Point(68, 943);
            btKeluarAdmin.Name = "btKeluarAdmin";
            btKeluarAdmin.Size = new Size(286, 56);
            btKeluarAdmin.TabIndex = 6;
            btKeluarAdmin.Text = "Keluar";
            btKeluarAdmin.UseVisualStyleBackColor = false;
            btKeluarAdmin.Click += btKeluarAdmin_Click;
            // 
            // btProfileAdmin
            // 
            btProfileAdmin.BackColor = SystemColors.HotTrack;
            btProfileAdmin.FlatStyle = FlatStyle.Popup;
            btProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProfileAdmin.ForeColor = Color.White;
            btProfileAdmin.Location = new Point(68, 872);
            btProfileAdmin.Name = "btProfileAdmin";
            btProfileAdmin.Size = new Size(286, 56);
            btProfileAdmin.TabIndex = 5;
            btProfileAdmin.Text = "Profile";
            btProfileAdmin.UseVisualStyleBackColor = false;
            btProfileAdmin.Click += btProfileAdmin_Click;
            // 
            // btRiwayatPeminjaman
            // 
            btRiwayatPeminjaman.BackColor = SystemColors.HotTrack;
            btRiwayatPeminjaman.FlatStyle = FlatStyle.Popup;
            btRiwayatPeminjaman.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatPeminjaman.ForeColor = Color.White;
            btRiwayatPeminjaman.Location = new Point(68, 527);
            btRiwayatPeminjaman.Name = "btRiwayatPeminjaman";
            btRiwayatPeminjaman.Size = new Size(286, 56);
            btRiwayatPeminjaman.TabIndex = 4;
            btRiwayatPeminjaman.Text = "Riwayat Peminjaman";
            btRiwayatPeminjaman.UseVisualStyleBackColor = false;
            btRiwayatPeminjaman.Click += btRiwayatPeminjaman_Click;
            // 
            // btPeminjaman
            // 
            btPeminjaman.BackColor = SystemColors.HotTrack;
            btPeminjaman.FlatStyle = FlatStyle.Popup;
            btPeminjaman.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPeminjaman.ForeColor = Color.White;
            btPeminjaman.Location = new Point(68, 453);
            btPeminjaman.Name = "btPeminjaman";
            btPeminjaman.Size = new Size(286, 56);
            btPeminjaman.TabIndex = 3;
            btPeminjaman.Text = "Peminjaman";
            btPeminjaman.UseVisualStyleBackColor = false;
            btPeminjaman.Click += btPeminjaman_Click;
            // 
            // btKelolaBuku
            // 
            btKelolaBuku.BackColor = SystemColors.HotTrack;
            btKelolaBuku.FlatStyle = FlatStyle.Popup;
            btKelolaBuku.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btKelolaBuku.ForeColor = Color.White;
            btKelolaBuku.Location = new Point(68, 380);
            btKelolaBuku.Name = "btKelolaBuku";
            btKelolaBuku.Size = new Size(286, 56);
            btKelolaBuku.TabIndex = 2;
            btKelolaBuku.Text = "Kelola Buku";
            btKelolaBuku.UseVisualStyleBackColor = false;
            btKelolaBuku.Click += btKelolaBuku_Click;
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.Location = new Point(119, 284);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(197, 20);
            lblGmail.TabIndex = 1;
            lblGmail.Text = "Jamaludin@gmail.com";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(154, 256);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // pictureBoxVektoradmin
            // 
            pictureBoxVektoradmin.BackColor = SystemColors.Highlight;
            pictureBoxVektoradmin.Image = (Image)resources.GetObject("pictureBoxVektoradmin.Image");
            pictureBoxVektoradmin.Location = new Point(79, 45);
            pictureBoxVektoradmin.Name = "pictureBoxVektoradmin";
            pictureBoxVektoradmin.Size = new Size(256, 189);
            pictureBoxVektoradmin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVektoradmin.TabIndex = 1;
            pictureBoxVektoradmin.TabStop = false;
            // 
            // pictureBoxPerpusAdmin
            // 
            pictureBoxPerpusAdmin.Image = (Image)resources.GetObject("pictureBoxPerpusAdmin.Image");
            pictureBoxPerpusAdmin.Location = new Point(415, 0);
            pictureBoxPerpusAdmin.Name = "pictureBoxPerpusAdmin";
            pictureBoxPerpusAdmin.Size = new Size(1507, 275);
            pictureBoxPerpusAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerpusAdmin.TabIndex = 2;
            pictureBoxPerpusAdmin.TabStop = false;
            // 
            // lblhaiAdmin
            // 
            lblhaiAdmin.AutoSize = true;
            lblhaiAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhaiAdmin.Location = new Point(438, 24);
            lblhaiAdmin.Name = "lblhaiAdmin";
            lblhaiAdmin.Size = new Size(172, 25);
            lblhaiAdmin.TabIndex = 3;
            lblhaiAdmin.Text = "Selamat Datang,";
            // 
            // lblhai1Admin
            // 
            lblhai1Admin.AutoSize = true;
            lblhai1Admin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblhai1Admin.Location = new Point(438, 64);
            lblhai1Admin.Name = "lblhai1Admin";
            lblhai1Admin.Size = new Size(73, 25);
            lblhai1Admin.TabIndex = 4;
            lblhai1Admin.Text = "Admin";
            // 
            // lblDaftarBuku
            // 
            lblDaftarBuku.AutoSize = true;
            lblDaftarBuku.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaftarBuku.Location = new Point(23, 29);
            lblDaftarBuku.Name = "lblDaftarBuku";
            lblDaftarBuku.Size = new Size(125, 25);
            lblDaftarBuku.TabIndex = 5;
            lblDaftarBuku.Text = "Daftar Buku";
            // 
            // tbDaftarBukuAdmin
            // 
            tbDaftarBukuAdmin.BackColor = Color.Silver;
            tbDaftarBukuAdmin.Location = new Point(58, 76);
            tbDaftarBukuAdmin.Multiline = true;
            tbDaftarBukuAdmin.Name = "tbDaftarBukuAdmin";
            tbDaftarBukuAdmin.Size = new Size(1400, 34);
            tbDaftarBukuAdmin.TabIndex = 6;
            // 
            // pnlDaftarBukuAdmin
            // 
            pnlDaftarBukuAdmin.Controls.Add(dgvKelolaBukuAdmin);
            pnlDaftarBukuAdmin.Controls.Add(tbDaftarBukuAdmin);
            pnlDaftarBukuAdmin.Controls.Add(lblDaftarBuku);
            pnlDaftarBukuAdmin.Location = new Point(418, 318);
            pnlDaftarBukuAdmin.Name = "pnlDaftarBukuAdmin";
            pnlDaftarBukuAdmin.Size = new Size(1507, 805);
            pnlDaftarBukuAdmin.TabIndex = 7;
            // 
            // dgvKelolaBukuAdmin
            // 
            dgvKelolaBukuAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKelolaBukuAdmin.Location = new Point(23, 150);
            dgvKelolaBukuAdmin.Name = "dgvKelolaBukuAdmin";
            dgvKelolaBukuAdmin.RowHeadersWidth = 51;
            dgvKelolaBukuAdmin.Size = new Size(1460, 625);
            dgvKelolaBukuAdmin.TabIndex = 7;
            // 
            // pnlPeminjamanAdmin
            // 
            pnlPeminjamanAdmin.Controls.Add(dataGridView1);
            pnlPeminjamanAdmin.Controls.Add(lblBookingAdmin);
            pnlPeminjamanAdmin.Location = new Point(438, 309);
            pnlPeminjamanAdmin.Name = "pnlPeminjamanAdmin";
            pnlPeminjamanAdmin.Size = new Size(1507, 805);
            pnlPeminjamanAdmin.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1460, 687);
            dataGridView1.TabIndex = 7;
            // 
            // lblBookingAdmin
            // 
            lblBookingAdmin.AutoSize = true;
            lblBookingAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingAdmin.Location = new Point(23, 29);
            lblBookingAdmin.Name = "lblBookingAdmin";
            lblBookingAdmin.Size = new Size(302, 25);
            lblBookingAdmin.TabIndex = 5;
            lblBookingAdmin.Text = "Booking dan Sedang Dipinjam";
            // 
            // pnlRiwayatPeminjaman
            // 
            pnlRiwayatPeminjaman.Controls.Add(dataGridView2);
            pnlRiwayatPeminjaman.Controls.Add(label1);
            pnlRiwayatPeminjaman.Location = new Point(461, 288);
            pnlRiwayatPeminjaman.Name = "pnlRiwayatPeminjaman";
            pnlRiwayatPeminjaman.Size = new Size(1507, 805);
            pnlRiwayatPeminjaman.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 88);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1460, 687);
            dataGridView2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 5;
            label1.Text = "Riwayat Peminjaman";
            // 
            // pnlProfileAdmin
            // 
            pnlProfileAdmin.Controls.Add(lblPasswordProfileAdmin);
            pnlProfileAdmin.Controls.Add(btPasswordProfileAdmin);
            pnlProfileAdmin.Controls.Add(lblNoteleponProfileAdmin);
            pnlProfileAdmin.Controls.Add(tbNoTeleponProfileAdmin);
            pnlProfileAdmin.Controls.Add(lblEmailProfileAdmin);
            pnlProfileAdmin.Controls.Add(tbEmailProfileAdmin);
            pnlProfileAdmin.Controls.Add(lblNamaProfileAdmin);
            pnlProfileAdmin.Controls.Add(tbNamaProfileAdmin);
            pnlProfileAdmin.Controls.Add(lblUsernameProfileAdmin);
            pnlProfileAdmin.Controls.Add(tbUsernameAdmin);
            pnlProfileAdmin.Controls.Add(lblProfileAdmin);
            pnlProfileAdmin.Location = new Point(501, 280);
            pnlProfileAdmin.Name = "pnlProfileAdmin";
            pnlProfileAdmin.Size = new Size(1507, 805);
            pnlProfileAdmin.TabIndex = 10;
            pnlProfileAdmin.Paint += pnlProfileAdmin_Paint;
            // 
            // lblPasswordProfileAdmin
            // 
            lblPasswordProfileAdmin.AutoSize = true;
            lblPasswordProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordProfileAdmin.Location = new Point(58, 503);
            lblPasswordProfileAdmin.Name = "lblPasswordProfileAdmin";
            lblPasswordProfileAdmin.Size = new Size(106, 25);
            lblPasswordProfileAdmin.TabIndex = 15;
            lblPasswordProfileAdmin.Text = "Password";
            // 
            // btPasswordProfileAdmin
            // 
            btPasswordProfileAdmin.BackColor = Color.Silver;
            btPasswordProfileAdmin.Location = new Point(58, 534);
            btPasswordProfileAdmin.Multiline = true;
            btPasswordProfileAdmin.Name = "btPasswordProfileAdmin";
            btPasswordProfileAdmin.Size = new Size(1400, 34);
            btPasswordProfileAdmin.TabIndex = 14;
            // 
            // lblNoteleponProfileAdmin
            // 
            lblNoteleponProfileAdmin.AutoSize = true;
            lblNoteleponProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoteleponProfileAdmin.Location = new Point(58, 413);
            lblNoteleponProfileAdmin.Name = "lblNoteleponProfileAdmin";
            lblNoteleponProfileAdmin.Size = new Size(124, 25);
            lblNoteleponProfileAdmin.TabIndex = 13;
            lblNoteleponProfileAdmin.Text = "No.Telepon";
            // 
            // tbNoTeleponProfileAdmin
            // 
            tbNoTeleponProfileAdmin.BackColor = Color.Silver;
            tbNoTeleponProfileAdmin.Location = new Point(58, 444);
            tbNoTeleponProfileAdmin.Multiline = true;
            tbNoTeleponProfileAdmin.Name = "tbNoTeleponProfileAdmin";
            tbNoTeleponProfileAdmin.Size = new Size(1400, 34);
            tbNoTeleponProfileAdmin.TabIndex = 12;
            // 
            // lblEmailProfileAdmin
            // 
            lblEmailProfileAdmin.AutoSize = true;
            lblEmailProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailProfileAdmin.Location = new Point(58, 311);
            lblEmailProfileAdmin.Name = "lblEmailProfileAdmin";
            lblEmailProfileAdmin.Size = new Size(65, 25);
            lblEmailProfileAdmin.TabIndex = 11;
            lblEmailProfileAdmin.Text = "Email";
            // 
            // tbEmailProfileAdmin
            // 
            tbEmailProfileAdmin.BackColor = Color.Silver;
            tbEmailProfileAdmin.Location = new Point(58, 342);
            tbEmailProfileAdmin.Multiline = true;
            tbEmailProfileAdmin.Name = "tbEmailProfileAdmin";
            tbEmailProfileAdmin.Size = new Size(1400, 34);
            tbEmailProfileAdmin.TabIndex = 10;
            // 
            // lblNamaProfileAdmin
            // 
            lblNamaProfileAdmin.AutoSize = true;
            lblNamaProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProfileAdmin.Location = new Point(58, 218);
            lblNamaProfileAdmin.Name = "lblNamaProfileAdmin";
            lblNamaProfileAdmin.Size = new Size(68, 25);
            lblNamaProfileAdmin.TabIndex = 9;
            lblNamaProfileAdmin.Text = "Nama";
            // 
            // tbNamaProfileAdmin
            // 
            tbNamaProfileAdmin.BackColor = Color.Silver;
            tbNamaProfileAdmin.Location = new Point(58, 249);
            tbNamaProfileAdmin.Multiline = true;
            tbNamaProfileAdmin.Name = "tbNamaProfileAdmin";
            tbNamaProfileAdmin.Size = new Size(1400, 34);
            tbNamaProfileAdmin.TabIndex = 8;
            // 
            // lblUsernameProfileAdmin
            // 
            lblUsernameProfileAdmin.AutoSize = true;
            lblUsernameProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameProfileAdmin.Location = new Point(58, 125);
            lblUsernameProfileAdmin.Name = "lblUsernameProfileAdmin";
            lblUsernameProfileAdmin.Size = new Size(110, 25);
            lblUsernameProfileAdmin.TabIndex = 7;
            lblUsernameProfileAdmin.Text = "Username";
            // 
            // tbUsernameAdmin
            // 
            tbUsernameAdmin.BackColor = Color.Silver;
            tbUsernameAdmin.Location = new Point(58, 156);
            tbUsernameAdmin.Multiline = true;
            tbUsernameAdmin.Name = "tbUsernameAdmin";
            tbUsernameAdmin.Size = new Size(1400, 34);
            tbUsernameAdmin.TabIndex = 6;
            tbUsernameAdmin.TextChanged += tbUsernameAdmin_TextChanged;
            // 
            // lblProfileAdmin
            // 
            lblProfileAdmin.AutoSize = true;
            lblProfileAdmin.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileAdmin.Location = new Point(23, 29);
            lblProfileAdmin.Name = "lblProfileAdmin";
            lblProfileAdmin.Size = new Size(73, 25);
            lblProfileAdmin.TabIndex = 5;
            lblProfileAdmin.Text = "Profile";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(424, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 11;
            // 
            // V_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(nightControlBox1);
            Controls.Add(pnlProfileAdmin);
            Controls.Add(pnlRiwayatPeminjaman);
            Controls.Add(pnlDaftarBukuAdmin);
            Controls.Add(lblhai1Admin);
            Controls.Add(pnlPeminjamanAdmin);
            Controls.Add(lblhaiAdmin);
            Controls.Add(pictureBoxPerpusAdmin);
            Controls.Add(pictureBoxVektoradmin);
            Controls.Add(pnlAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Admin";
            Text = "V_Admin";
            Load += V_Admin_Load;
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVektoradmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerpusAdmin).EndInit();
            pnlDaftarBukuAdmin.ResumeLayout(false);
            pnlDaftarBukuAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBukuAdmin).EndInit();
            pnlPeminjamanAdmin.ResumeLayout(false);
            pnlPeminjamanAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlRiwayatPeminjaman.ResumeLayout(false);
            pnlRiwayatPeminjaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            pnlProfileAdmin.ResumeLayout(false);
            pnlProfileAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void V_Admin_Load(object sender, EventArgs e)
        {
            
           
           
        }

        private void pnlProfileAdmin_Paint(object sender, PaintEventArgs e)
        {
            /*throw new NotImplementedException();*/
          
        }

        private void btPeminjaman_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.CornflowerBlue;
            btPeminjaman.BackColor = Color.Black;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Hide();
            this.pnlPeminjamanAdmin.Show();
            this.pnlPeminjamanAdmin.Dock = DockStyle.Bottom;
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();
        }

        private void btKelolaBuku_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.Black;
            btPeminjaman.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Show();
            this.pnlDaftarBukuAdmin.Dock = DockStyle.Bottom;
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();

        }

        #endregion

        private Panel pnlAdmin;
        private PictureBox pictureBoxVektoradmin;
        private Button btRiwayatPeminjaman;
        private Button btPeminjaman;
        private Button btKelolaBuku;
        private Label lblGmail;
        private Label lblUsername;
        private Button btKeluarAdmin;
        private Button btProfileAdmin;
        private PictureBox pictureBoxPerpusAdmin;
        private Panel pnlTambahBuku;
        private Label lblhaiAdmin;
        private Label lblhai1Admin;
        private Label lblDaftarBuku;
        private TextBox tbDaftarBukuAdmin;
        private Panel pnlDaftarBukuAdmin;
        private DataGridView dgvKelolaBukuAdmin;
        private Panel pnlPeminjamanAdmin;
        private DataGridView dataGridView1;
        private Label lblBookingAdmin;
        private Panel pnlRiwayatPeminjaman;
        private DataGridView dataGridView2;
        private Label label1;
        private Panel pnlProfileAdmin;
        private Label lblProfileAdmin;
        private Label lblNamaProfileAdmin;
        private TextBox tbNamaProfileAdmin;
        private Label lblUsernameProfileAdmin;
        private TextBox tbUsernameAdmin;
        private Label lblPasswordProfileAdmin;
        private TextBox btPasswordProfileAdmin;
        private Label lblNoteleponProfileAdmin;
        private TextBox tbNoTeleponProfileAdmin;
        private Label lblEmailProfileAdmin;
        private TextBox tbEmailProfileAdmin;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}