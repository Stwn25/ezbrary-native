using Project_PBO_03.Core;
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
        /*private object pbDekorTeks;*/

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
            string username_pengguna = tbUsernameM.Text;
            string pass_pengguna = tbPasswordD.Text;

            bool loginResult = cekLoginPengguna.Login(username_pengguna, pass_pengguna);

            if (loginResult)
            {
                V_User User = new V_User();
                User.Show();
            }
            else
            {
                MessageBox.Show("Login gagal, harap cek username dan password", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btMasuksbgadmin_Click(object sender, EventArgs e)
        {
            string username_admin = tbUsernameM.Text;
            string pass_admin = tbPasswordD.Text;


            bool loginResult = cekLoginAdmin.Login(username_admin, pass_admin);

            if (loginResult)
            {
                this.pnlMasuk.Hide();
                this.pnlKodevAdmin.Show();
                this.pnlKodevAdmin.Dock = DockStyle.Left;
            }
            else
            {
                MessageBox.Show("Login gagal, harap cek username dan password", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                V_Admin admin = new V_Admin();
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
    }
}
