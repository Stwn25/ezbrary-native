
namespace Project_PBO_03
{
    partial class V_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_User));
            pnlUser = new Panel();
            btKeluarUser = new Button();
            btProfileUser = new Button();
            btRiwayatPeminjamanUser = new Button();
            btBukuFavUser = new Button();
            btPeminjamanUser = new Button();
            lblEmailUser = new Label();
            lblUsernameUser = new Label();
            pictureBoxVectorUser = new PictureBox();
            pictureBoxPerpusUser = new PictureBox();
            lblHaiUser = new Label();
            lblHai1User = new Label();
            pnlPeminjamanUser = new Panel();
            ucDetailBukuUser1 = new View.ucDetailBukuUser();
            panel1 = new Panel();
            button1 = new Button();
            cbJenis = new ReaLTaiizor.Controls.DungeonComboBox();
            tbPeminjamanUser = new TextBox();
            dgvPeminjamanUser = new DataGridView();
            detailBuku = new DataGridViewButtonColumn();
            lblPeminjamanUser = new Label();
            pnlBukuFavUser = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pnlRiwayatUser = new Panel();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            pnlProfileUser = new Panel();
            btSimpanPerubahanU = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbPassU = new TextBox();
            tbTeleponU = new TextBox();
            tbEmailU = new TextBox();
            tbNamaProfileU = new TextBox();
            tbUsernameProfileU = new TextBox();
            label3 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVectorUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerpusUser).BeginInit();
            pnlPeminjamanUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjamanUser).BeginInit();
            pnlBukuFavUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlRiwayatUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            pnlProfileUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUser
            // 
            pnlUser.BackColor = SystemColors.Highlight;
            pnlUser.Controls.Add(btKeluarUser);
            pnlUser.Controls.Add(btProfileUser);
            pnlUser.Controls.Add(btRiwayatPeminjamanUser);
            pnlUser.Controls.Add(btBukuFavUser);
            pnlUser.Controls.Add(btPeminjamanUser);
            pnlUser.Controls.Add(lblEmailUser);
            pnlUser.Controls.Add(lblUsernameUser);
            pnlUser.Controls.Add(pictureBoxVectorUser);
            pnlUser.Dock = DockStyle.Left;
            pnlUser.Location = new Point(0, 0);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(421, 1080);
            pnlUser.TabIndex = 0;
            pnlUser.Paint += pnlUser_Paint;
            // 
            // btKeluarUser
            // 
            btKeluarUser.BackColor = SystemColors.HotTrack;
            btKeluarUser.Cursor = Cursors.Hand;
            btKeluarUser.FlatStyle = FlatStyle.Popup;
            btKeluarUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            btKeluarUser.ForeColor = Color.White;
            btKeluarUser.Location = new Point(69, 943);
            btKeluarUser.Name = "btKeluarUser";
            btKeluarUser.Size = new Size(286, 56);
            btKeluarUser.TabIndex = 6;
            btKeluarUser.Text = "Keluar";
            btKeluarUser.UseVisualStyleBackColor = false;
            btKeluarUser.Click += btKeluarUser_Click_1;
            // 
            // btProfileUser
            // 
            btProfileUser.BackColor = SystemColors.HotTrack;
            btProfileUser.Cursor = Cursors.Hand;
            btProfileUser.FlatStyle = FlatStyle.Popup;
            btProfileUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            btProfileUser.ForeColor = Color.White;
            btProfileUser.Location = new Point(69, 872);
            btProfileUser.Name = "btProfileUser";
            btProfileUser.Size = new Size(286, 56);
            btProfileUser.TabIndex = 5;
            btProfileUser.Text = "Profile";
            btProfileUser.UseVisualStyleBackColor = false;
            btProfileUser.Click += btProfileUser_Click;
            // 
            // btRiwayatPeminjamanUser
            // 
            btRiwayatPeminjamanUser.BackColor = SystemColors.HotTrack;
            btRiwayatPeminjamanUser.Cursor = Cursors.Hand;
            btRiwayatPeminjamanUser.FlatStyle = FlatStyle.Popup;
            btRiwayatPeminjamanUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            btRiwayatPeminjamanUser.ForeColor = Color.White;
            btRiwayatPeminjamanUser.Location = new Point(69, 527);
            btRiwayatPeminjamanUser.Name = "btRiwayatPeminjamanUser";
            btRiwayatPeminjamanUser.Size = new Size(286, 56);
            btRiwayatPeminjamanUser.TabIndex = 4;
            btRiwayatPeminjamanUser.Text = "Riwayat Peminjaman";
            btRiwayatPeminjamanUser.UseVisualStyleBackColor = false;
            btRiwayatPeminjamanUser.Click += btRiwayatPeminajamanUser_Click;
            // 
            // btBukuFavUser
            // 
            btBukuFavUser.BackColor = SystemColors.HotTrack;
            btBukuFavUser.Cursor = Cursors.Hand;
            btBukuFavUser.FlatStyle = FlatStyle.Popup;
            btBukuFavUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            btBukuFavUser.ForeColor = Color.White;
            btBukuFavUser.Location = new Point(69, 453);
            btBukuFavUser.Name = "btBukuFavUser";
            btBukuFavUser.Size = new Size(286, 56);
            btBukuFavUser.TabIndex = 3;
            btBukuFavUser.Text = "Buku Favorit";
            btBukuFavUser.UseVisualStyleBackColor = false;
            btBukuFavUser.Click += btBukuFavUser_Click;
            // 
            // btPeminjamanUser
            // 
            btPeminjamanUser.BackColor = SystemColors.HotTrack;
            btPeminjamanUser.Cursor = Cursors.Hand;
            btPeminjamanUser.FlatStyle = FlatStyle.Popup;
            btPeminjamanUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold);
            btPeminjamanUser.ForeColor = Color.White;
            btPeminjamanUser.Location = new Point(69, 380);
            btPeminjamanUser.Name = "btPeminjamanUser";
            btPeminjamanUser.Size = new Size(286, 56);
            btPeminjamanUser.TabIndex = 1;
            btPeminjamanUser.Text = "Peminjaman";
            btPeminjamanUser.UseVisualStyleBackColor = false;
            btPeminjamanUser.Click += btPeminjamanUser_Click;
            // 
            // lblEmailUser
            // 
            lblEmailUser.AutoSize = true;
            lblEmailUser.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailUser.ForeColor = Color.Black;
            lblEmailUser.Location = new Point(119, 284);
            lblEmailUser.Name = "lblEmailUser";
            lblEmailUser.Size = new Size(197, 20);
            lblEmailUser.TabIndex = 2;
            lblEmailUser.Text = "Jamaludin@gmail.com";
            // 
            // lblUsernameUser
            // 
            lblUsernameUser.AutoSize = true;
            lblUsernameUser.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameUser.ForeColor = Color.White;
            lblUsernameUser.Location = new Point(154, 256);
            lblUsernameUser.Name = "lblUsernameUser";
            lblUsernameUser.Size = new Size(110, 25);
            lblUsernameUser.TabIndex = 1;
            lblUsernameUser.Text = "Username";
            lblUsernameUser.Click += label1_Click;
            // 
            // pictureBoxVectorUser
            // 
            pictureBoxVectorUser.Image = (Image)resources.GetObject("pictureBoxVectorUser.Image");
            pictureBoxVectorUser.Location = new Point(79, 45);
            pictureBoxVectorUser.Name = "pictureBoxVectorUser";
            pictureBoxVectorUser.Size = new Size(256, 189);
            pictureBoxVectorUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVectorUser.TabIndex = 0;
            pictureBoxVectorUser.TabStop = false;
            // 
            // pictureBoxPerpusUser
            // 
            pictureBoxPerpusUser.Image = (Image)resources.GetObject("pictureBoxPerpusUser.Image");
            pictureBoxPerpusUser.Location = new Point(415, 0);
            pictureBoxPerpusUser.Name = "pictureBoxPerpusUser";
            pictureBoxPerpusUser.Size = new Size(1507, 275);
            pictureBoxPerpusUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerpusUser.TabIndex = 1;
            pictureBoxPerpusUser.TabStop = false;
            pictureBoxPerpusUser.Click += pictureBoxPerpusUser_Click;
            // 
            // lblHaiUser
            // 
            lblHaiUser.AutoSize = true;
            lblHaiUser.Font = new Font("Nunito", 11.999999F, FontStyle.Bold);
            lblHaiUser.ForeColor = Color.Black;
            lblHaiUser.Location = new Point(438, 24);
            lblHaiUser.Name = "lblHaiUser";
            lblHaiUser.Size = new Size(169, 28);
            lblHaiUser.TabIndex = 7;
            lblHaiUser.Text = "Selamat Datang,";
            // 
            // lblHai1User
            // 
            lblHai1User.AutoSize = true;
            lblHai1User.Font = new Font("Nunito", 11.999999F, FontStyle.Bold);
            lblHai1User.ForeColor = Color.Black;
            lblHai1User.Location = new Point(438, 64);
            lblHai1User.Name = "lblHai1User";
            lblHai1User.Size = new Size(56, 28);
            lblHai1User.TabIndex = 8;
            lblHai1User.Text = "User";
            // 
            // pnlPeminjamanUser
            // 
            pnlPeminjamanUser.Controls.Add(ucDetailBukuUser1);
            pnlPeminjamanUser.Controls.Add(panel1);
            pnlPeminjamanUser.Controls.Add(button1);
            pnlPeminjamanUser.Controls.Add(cbJenis);
            pnlPeminjamanUser.Controls.Add(tbPeminjamanUser);
            pnlPeminjamanUser.Controls.Add(dgvPeminjamanUser);
            pnlPeminjamanUser.Controls.Add(lblPeminjamanUser);
            pnlPeminjamanUser.Location = new Point(416, 275);
            pnlPeminjamanUser.Name = "pnlPeminjamanUser";
            pnlPeminjamanUser.Size = new Size(1507, 805);
            pnlPeminjamanUser.TabIndex = 9;
            pnlPeminjamanUser.Paint += pnlPeminjamanUser_Paint_1;
            // 
            // ucDetailBukuUser1
            // 
            ucDetailBukuUser1.BackColor = Color.White;
            ucDetailBukuUser1.BorderStyle = BorderStyle.FixedSingle;
            ucDetailBukuUser1.id_pengguna = 0;
            ucDetailBukuUser1.Location = new Point(169, 105);
            ucDetailBukuUser1.Margin = new Padding(3, 4, 3, 4);
            ucDetailBukuUser1.Name = "ucDetailBukuUser1";
            ucDetailBukuUser1.Size = new Size(907, 781);
            ucDetailBukuUser1.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Location = new Point(123, 43);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1125, 69);
            button1.Name = "button1";
            button1.Size = new Size(72, 36);
            button1.TabIndex = 14;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbJenis
            // 
            cbJenis.BackColor = Color.Black;
            cbJenis.ColorA = Color.FromArgb(246, 132, 85);
            cbJenis.ColorB = Color.FromArgb(231, 108, 57);
            cbJenis.ColorC = Color.FromArgb(242, 241, 240);
            cbJenis.ColorD = Color.FromArgb(253, 252, 252);
            cbJenis.ColorE = Color.FromArgb(239, 237, 236);
            cbJenis.ColorF = Color.FromArgb(180, 180, 180);
            cbJenis.ColorG = Color.FromArgb(119, 119, 118);
            cbJenis.ColorH = Color.FromArgb(224, 222, 220);
            cbJenis.ColorI = Color.FromArgb(250, 249, 249);
            cbJenis.DrawMode = DrawMode.OwnerDrawFixed;
            cbJenis.DropDownHeight = 100;
            cbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenis.Font = new Font("Segoe UI", 10F);
            cbJenis.ForeColor = Color.Black;
            cbJenis.FormattingEnabled = true;
            cbJenis.HoverSelectionColor = Color.Empty;
            cbJenis.IntegralHeight = false;
            cbJenis.ItemHeight = 20;
            cbJenis.Location = new Point(23, 80);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(169, 26);
            cbJenis.StartIndex = 0;
            cbJenis.TabIndex = 13;
            cbJenis.SelectedIndexChanged += cbJenis_SelectedIndexChanged;
            // 
            // tbPeminjamanUser
            // 
            tbPeminjamanUser.BackColor = Color.White;
            tbPeminjamanUser.BorderStyle = BorderStyle.FixedSingle;
            tbPeminjamanUser.Cursor = Cursors.IBeam;
            tbPeminjamanUser.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPeminjamanUser.Location = new Point(377, 72);
            tbPeminjamanUser.Multiline = true;
            tbPeminjamanUser.Name = "tbPeminjamanUser";
            tbPeminjamanUser.Size = new Size(741, 34);
            tbPeminjamanUser.TabIndex = 12;
            tbPeminjamanUser.TextChanged += tbPeminjamanUser_TextChanged;
            // 
            // dgvPeminjamanUser
            // 
            dgvPeminjamanUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeminjamanUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeminjamanUser.Columns.AddRange(new DataGridViewColumn[] { detailBuku });
            dgvPeminjamanUser.Location = new Point(23, 149);
            dgvPeminjamanUser.Name = "dgvPeminjamanUser";
            dgvPeminjamanUser.RowHeadersWidth = 51;
            dgvPeminjamanUser.Size = new Size(1461, 625);
            dgvPeminjamanUser.TabIndex = 11;
            dgvPeminjamanUser.CellContentClick += dgvPeminjamanUser_CellContentClick;
            // 
            // detailBuku
            // 
            detailBuku.HeaderText = "Detail";
            detailBuku.MinimumWidth = 6;
            detailBuku.Name = "detailBuku";
            detailBuku.Text = "Detail";
            detailBuku.UseColumnTextForButtonValue = true;
            // 
            // lblPeminjamanUser
            // 
            lblPeminjamanUser.AutoSize = true;
            lblPeminjamanUser.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeminjamanUser.ForeColor = Color.Black;
            lblPeminjamanUser.Location = new Point(23, 29);
            lblPeminjamanUser.Name = "lblPeminjamanUser";
            lblPeminjamanUser.Size = new Size(128, 28);
            lblPeminjamanUser.TabIndex = 10;
            lblPeminjamanUser.Text = "Peminjaman";
            // 
            // pnlBukuFavUser
            // 
            pnlBukuFavUser.Controls.Add(dataGridView1);
            pnlBukuFavUser.Controls.Add(label1);
            pnlBukuFavUser.Location = new Point(416, 275);
            pnlBukuFavUser.Name = "pnlBukuFavUser";
            pnlBukuFavUser.Size = new Size(1507, 805);
            pnlBukuFavUser.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1461, 687);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 10;
            label1.Text = "Buku Favorit";
            // 
            // pnlRiwayatUser
            // 
            pnlRiwayatUser.Controls.Add(dataGridView2);
            pnlRiwayatUser.Controls.Add(label2);
            pnlRiwayatUser.Location = new Point(415, 275);
            pnlRiwayatUser.Name = "pnlRiwayatUser";
            pnlRiwayatUser.Size = new Size(1507, 805);
            pnlRiwayatUser.TabIndex = 14;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 88);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1461, 687);
            dataGridView2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 29);
            label2.Name = "label2";
            label2.Size = new Size(211, 25);
            label2.TabIndex = 10;
            label2.Text = "Riwayat Peminjaman";
            // 
            // pnlProfileUser
            // 
            pnlProfileUser.Controls.Add(btSimpanPerubahanU);
            pnlProfileUser.Controls.Add(label8);
            pnlProfileUser.Controls.Add(label7);
            pnlProfileUser.Controls.Add(label6);
            pnlProfileUser.Controls.Add(label5);
            pnlProfileUser.Controls.Add(label4);
            pnlProfileUser.Controls.Add(tbPassU);
            pnlProfileUser.Controls.Add(tbTeleponU);
            pnlProfileUser.Controls.Add(tbEmailU);
            pnlProfileUser.Controls.Add(tbNamaProfileU);
            pnlProfileUser.Controls.Add(tbUsernameProfileU);
            pnlProfileUser.Controls.Add(label3);
            pnlProfileUser.Location = new Point(415, 275);
            pnlProfileUser.Name = "pnlProfileUser";
            pnlProfileUser.Size = new Size(1507, 805);
            pnlProfileUser.TabIndex = 15;
            pnlProfileUser.Paint += pnlProfileUser_Paint;
            // 
            // btSimpanPerubahanU
            // 
            btSimpanPerubahanU.BackColor = SystemColors.HotTrack;
            btSimpanPerubahanU.Cursor = Cursors.Hand;
            btSimpanPerubahanU.FlatStyle = FlatStyle.Flat;
            btSimpanPerubahanU.Font = new Font("Microsoft Sans Serif", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSimpanPerubahanU.ForeColor = Color.White;
            btSimpanPerubahanU.Location = new Point(627, 587);
            btSimpanPerubahanU.Name = "btSimpanPerubahanU";
            btSimpanPerubahanU.Size = new Size(293, 45);
            btSimpanPerubahanU.TabIndex = 22;
            btSimpanPerubahanU.Text = "Simpan Perubahan";
            btSimpanPerubahanU.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(58, 464);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 21;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(58, 379);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 20;
            label7.Text = "No. Telepon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(58, 288);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(58, 205);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 18;
            label5.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(58, 125);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 16;
            label4.Text = "Username";
            // 
            // tbPassU
            // 
            tbPassU.BackColor = Color.White;
            tbPassU.BorderStyle = BorderStyle.FixedSingle;
            tbPassU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassU.Location = new Point(58, 495);
            tbPassU.Multiline = true;
            tbPassU.Name = "tbPassU";
            tbPassU.Size = new Size(1400, 34);
            tbPassU.TabIndex = 17;
            // 
            // tbTeleponU
            // 
            tbTeleponU.BackColor = Color.White;
            tbTeleponU.BorderStyle = BorderStyle.FixedSingle;
            tbTeleponU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTeleponU.Location = new Point(58, 409);
            tbTeleponU.Multiline = true;
            tbTeleponU.Name = "tbTeleponU";
            tbTeleponU.Size = new Size(1400, 34);
            tbTeleponU.TabIndex = 16;
            // 
            // tbEmailU
            // 
            tbEmailU.BackColor = Color.White;
            tbEmailU.BorderStyle = BorderStyle.FixedSingle;
            tbEmailU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmailU.Location = new Point(58, 323);
            tbEmailU.Multiline = true;
            tbEmailU.Name = "tbEmailU";
            tbEmailU.Size = new Size(1400, 34);
            tbEmailU.TabIndex = 15;
            // 
            // tbNamaProfileU
            // 
            tbNamaProfileU.BackColor = Color.White;
            tbNamaProfileU.BorderStyle = BorderStyle.FixedSingle;
            tbNamaProfileU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbNamaProfileU.Location = new Point(58, 237);
            tbNamaProfileU.Multiline = true;
            tbNamaProfileU.Name = "tbNamaProfileU";
            tbNamaProfileU.Size = new Size(1400, 34);
            tbNamaProfileU.TabIndex = 14;
            // 
            // tbUsernameProfileU
            // 
            tbUsernameProfileU.BackColor = Color.White;
            tbUsernameProfileU.BorderStyle = BorderStyle.FixedSingle;
            tbUsernameProfileU.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsernameProfileU.Location = new Point(58, 156);
            tbUsernameProfileU.Multiline = true;
            tbUsernameProfileU.Name = "tbUsernameProfileU";
            tbUsernameProfileU.Size = new Size(1400, 34);
            tbUsernameProfileU.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 29);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 10;
            label3.Text = "Profile";
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1781, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 7;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // V_User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(nightControlBox1);
            Controls.Add(lblHai1User);
            Controls.Add(lblHaiUser);
            Controls.Add(pictureBoxPerpusUser);
            Controls.Add(pnlUser);
            Controls.Add(pnlPeminjamanUser);
            Controls.Add(pnlProfileUser);
            Controls.Add(pnlRiwayatUser);
            Controls.Add(pnlBukuFavUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_User";
            Text = "V_User";
            Load += V_User_Load;
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVectorUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerpusUser).EndInit();
            pnlPeminjamanUser.ResumeLayout(false);
            pnlPeminjamanUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjamanUser).EndInit();
            pnlBukuFavUser.ResumeLayout(false);
            pnlBukuFavUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlRiwayatUser.ResumeLayout(false);
            pnlRiwayatUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            pnlProfileUser.ResumeLayout(false);
            pnlProfileUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btRiwayatPeminajamanUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.Black;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Show();
            this.pnlProfileUser.Hide();
           
        }

       

        private void btPeminjamanUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.Black;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Show();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*throw new NotImplementedException();*/
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {
            /*throw new NotImplementedException();*/
        }

        #endregion

        private Panel pnlUser;
        private Label lblUsernameUser;
        private PictureBox pictureBoxVectorUser;
        private Button btKeluarUser;
        private Button btProfileUser;
        private Button btRiwayatPeminjamanUser;
        private Button btBukuFavUser;
        private Button btPeminjamanUser;
        private Label lblEmailUser;
        private PictureBox pictureBoxPerpusUser;
        private Label lblHaiUser;
        private Label lblHai1User;
        private Panel pnlPeminjamanUser;
        private TextBox tbPeminjamanUser;
        private DataGridView dgvPeminjamanUser;
        private Label lblPeminjamanUser;
        private Panel pnlBukuFavUser;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel pnlRiwayatUser;
        private DataGridView dataGridView2;
        private Label label2;
        private Panel pnlProfileUser;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbPassU;
        private TextBox tbTeleponU;
        private TextBox tbEmailU;
        private TextBox tbNamaProfileU;
        private TextBox tbUsernameProfileU;
        private Label label3;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Button btSimpanPerubahanU;
        private Button button1;
        private ReaLTaiizor.Controls.DungeonComboBox cbJenis;
        private DataGridViewButtonColumn detailBuku;
        private Panel panel1;
        private View.ucDetailBukuUser ucDetailBukuUser1;
    }
}