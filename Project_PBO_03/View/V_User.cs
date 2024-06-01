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
    public partial class V_User : Form
    {
        public V_User()
        {
            InitializeComponent();
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

        private void btPeminjaman_Click(object sender, EventArgs e)
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
            this.pnlPeminjamanUser.Dock = DockStyle.Bottom;
        }

        private void btBukuFavUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.Black;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Show();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            this.pnlBukuFavUser.Dock = DockStyle.Bottom;
        }

        private void btRiwayatPeminjamanUser_Click(object sender, EventArgs e)
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
            this.pnlRiwayatUser.Dock = DockStyle.Bottom;
        }

        private void btProfileUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.Black;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Show();
            this.pnlProfileUser.Dock = DockStyle.Bottom;
        }

/*        private void btKeluarUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.Black;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            Application.Exit();
        }*/

        private void pnlProfileUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRiwayatUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBukuFavUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPeminjamanUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btKeluarUser_Click_1(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.Black;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            Application.Exit();
        }
    }
}
