using Project_PBO_03.Context;
using Project_PBO_03.Core;
using Project_PBO_03.Model;
using Project_PBO_03.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO_03
{
    public partial class V_Login : Form
    {
        public string username { get; set; }

        public V_Login()
        {

            InitializeComponent();
            this.pnlAwal.Show();
            this.pnlMasuk.Hide();
            this.pnlDaftar.Hide();
            this.pnlKodevSA.Hide();
            this.pnlKodevAdmin.Hide();
            this.pnlMasukSA.Hide();

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void linkMasuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pnlDaftar.Hide();
            this.pnlMasuk.Dock = DockStyle.Left;
            this.pnlMasuk.Show();
            this.pnlAwal.Hide();
            this.pnlMasukSA.Hide();
        }

        private void btMasuk_Click(object sender, EventArgs e)
        {
            this.pnlAwal.Hide();
            this.pnlMasuk.Dock = DockStyle.Left;
            this.pnlMasuk.Show();
            this.pnlDaftar.Hide();
            this.pbDekor.Show();
            this.pbDekorText.Show();
            this.pnlMasukSA.Hide();
        }

        private void btDaftar_Click(object sender, EventArgs e)
        {
            this.pnlMasuk.Hide();
            this.pnlDaftar.Dock = DockStyle.Left;
            this.pnlDaftar.Show();
            this.pnlAwal.Hide();
            this.pbDekor.Show();
            this.pbDekorText.Show();
            this.pnlMasukSA.Hide();
        }

        private void linkDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.pnlMasuk.Hide();
            this.pnlDaftar.Dock = DockStyle.Left;
            this.pnlDaftar.Show();
            this.pnlAwal.Hide();
            this.pnlMasukSA.Hide();
        }

        private void pbSAM_Click(object sender, EventArgs e)
        {
            this.pnlMasukSA.Show();
            this.pnlMasukSA.Dock = DockStyle.Left;
            this.pnlMasuk.Hide();
            this.pnlDaftar.Hide();
            this.pnlAwal.Hide();
        }

        private void pbSAD_Click(object sender, EventArgs e)
        {
            this.pnlMasukSA.Show();
            this.pnlMasukSA.Dock = DockStyle.Left;
            this.pnlMasuk.Hide();
            this.pnlDaftar.Hide();
            this.pnlAwal.Hide();
        }

        private void pnlAwal_Paint(object sender, PaintEventArgs e)
        {
            this.pnlMasuk.Hide();
            this.pnlDaftar.Hide();
            this.pnlMasukSA.Hide();
            this.pbDekor.Hide();
            this.pbDekorText.Hide();
            this.pnlKodevAdmin.Hide();
            this.pnlKodevSA.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.pnlMasukSA.Hide();
            this.pnlMasuk.Dock = DockStyle.Left;
            this.pnlMasuk.Show();
            this.pnlDaftar.Hide();
            this.pnlAwal.Hide();
        }

        private void btMasukM_Click(object sender, EventArgs e)
        {
            string input_pengguna = tbUsernameM.Text.Trim();
            string pass_pengguna = tbPasswordD.Text.Trim();

            if (string.IsNullOrWhiteSpace(input_pengguna) || string.IsNullOrWhiteSpace(pass_pengguna))
            {
                MessageBox.Show("Masukkan username dan password");
                return;
            }
            else
            {
                DataTable dt = PenggunaContext.login(input_pengguna, pass_pengguna);
                
                if (dt.Rows.Count > 0)
                {
                    int Iduser = Convert.ToInt32(dt.Rows[0]["iduser"]);
                    string username = dt.Rows[0]["usrnmeuser"].ToString();
                    this.username = username;
                    this.pnlMasuk.Hide();
                    this.pnlAwal.Show();
                    V_User User = new V_User(username);
                    User.Show();
                }
                else
                {
                    MessageBox.Show($"username atau password salah, {dt.Rows.Count}");
                }
            }
        }

        private void btMasuksbgadmin_Click(object sender, EventArgs e)
        {
            string username_admin = tbUsernameM.Text.Trim();
            string pass_admin = tbPasswordD.Text.Trim();


            if (string.IsNullOrWhiteSpace(username_admin) || string.IsNullOrWhiteSpace(pass_admin))
            {
                MessageBox.Show("Masukkan username dan password");
                return;
            }
            else
            {
                DataTable dt = AdminContext.loginadmin(username_admin, pass_admin);

                if (dt.Rows.Count > 0)
                {
                    var Idadmin = Convert.ToInt32(dt.Rows[0]["idadmin"]);
                    string usernameadmin= dt.Rows[0]["usrnmeadmin"].ToString();
                    this.iduser = Idadmin;
                    this.input = username_admin;
                    this.pnlMasuk.Hide();
                    this.pnlAwal.Show();
                    V_Admin admin = new V_Admin(input);
                    admin.Show();
                }
                else
                {
                    MessageBox.Show($"username atau password salah, {dt.Rows.Count}");
                }
            }
        }

        private void pnlKodevAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSubmitAdmin_Click(object sender, EventArgs e)
        {
            string kode_verif = "1234567890";

            if (tbKodevAdmin.Text == kode_verif)
            {
                tbKodevAdmin.Text = default;
                this.pnlAwal.Show();
                this.pnlKodevAdmin.Hide();
                V_Admin admin = new V_Admin(tbUsernameM.Text);
                admin.Show();
            }
            else
            {
                MessageBox.Show("Verifikasi salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPasswD_TextChanged(object sender, EventArgs e)
        {
            int Hitung_Karakter = tbPasswD.Text.Length;

            if (Hitung_Karakter < 8)
            {
                label5.Text = "Karakter Password Anda Kurang";
            }
            else if (Hitung_Karakter < 12)
            {
                label5.Text = "Jumlah Karakter Password Anda Sesuai";
            }
            else if (Hitung_Karakter > 12)
            {
                label5.Text = "Password anda terlalu banyak karakter";
                tbPasswD.MaxLength = 20;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbMasukkanpasswdD_TextChanged(object sender, EventArgs e)
        {
            string Password = tbPasswD.Text;
            string KonfirmasiPassword = tbMasukkanpasswdD.Text;
            tbMasukkanpasswdD.MaxLength = 20;

            if (Password != KonfirmasiPassword)
            {
                label5.Text = "Password anda tidak sesuai";
            }
            else
            {
                label5.Text = "Password anda sudah sesuai";
            }

        }

        private void buttonMasukSA_Click(object sender, EventArgs e)
        {

        }

        private void btMasukSA_Click(object sender, EventArgs e)
        {
            string username_sa = tbUsernameMSA.Text;
            string pass_sa = tbPasswdMSA.Text;

            bool loginResult = cekLoginSuperAdmin.Login(username_sa, pass_sa);
            if (loginResult)
            {
                this.pnlMasukSA.Hide();
                this.pnlKodevSA.Show();
                this.pnlKodevSA.Dock = DockStyle.Left;
            }
            else
            {
                MessageBox.Show("Login gagal, harap cek username dan password", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSubmitSA_Click(object sender, EventArgs e)
        {
            string kode_verif = "0987654321";

            if (tbKodevSA.Text == kode_verif)
            {
                this.pnlKodevSA.Hide();
                this.pnlAwal.Show();
                V_SuperAdmin superadmin = new V_SuperAdmin();
                superadmin.Show();
            }
            else
            {
                MessageBox.Show("Verifikasi salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbEmailD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDaftarD_Click(object sender, EventArgs e)
        {
            string nama = tbNamaD.Text;
            string username = tbUsernameD.Text;
            string telepon = tbNotelpD.Text;
            string email = tbEmailD.Text;
            string password = tbPasswD.Text;
            string kpass = tbMasukkanpasswdD.Text;

            m_Pengguna penggunaBaru = new m_Pengguna
            {
                nama_pengguna = nama,
                username_pengguna = username,
                telp_pengguna = telepon,
                email_pengguna = email,
                pass_pengguna = password
            };

            if (password == kpass)
            {
                PenggunaContext.create(penggunaBaru);
                DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                {
                    this.pnlDaftar.Hide();
                    this.pnlAwal.Show();
                }
            }
            else
            {
                MessageBox.Show("Konfirmasi password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbUsernameMSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMasuk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUsernameM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
