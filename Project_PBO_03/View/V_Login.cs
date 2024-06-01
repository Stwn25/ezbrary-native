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
    }
}
