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
    public partial class V_Admin : Form
    {
        public V_Admin()
        {
            InitializeComponent();
            btKelolaBuku.BackColor = Color.Black;
            btPeminjaman.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Show();
            this.pnlTambahBukuAdmin.Hide();
            /*this.pnlDaftarBukuAdmin.Dock = DockStyle.Bottom;*/
            this.pnlPeminjamanAdmin.Hide();
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
            this.pnlTambahBukuAdmin.Hide();
            /*this.pnlDaftarBukuAdmin.Dock = DockStyle.Bottom;*/
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();
        }

        private void btProfileAdmin_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.CornflowerBlue;
            btPeminjaman.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.Black;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Hide();
            this.pnlTambahBukuAdmin.Hide();
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Show();
            /*this.pnlProfileAdmin.Dock = DockStyle.Bottom;*/

        }

        private void btRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.CornflowerBlue;
            btPeminjaman.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjaman.BackColor = Color.Black;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Hide();
            this.pnlTambahBukuAdmin.Hide();
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Show();
            /*this.pnlRiwayatPeminjaman.Dock = DockStyle.Bottom;*/
            this.pnlProfileAdmin.Hide();

        }

        private void btPeminjamanAdmin_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.CornflowerBlue;
            btPeminjaman.BackColor = Color.Black;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlDaftarBukuAdmin.Hide();
            this.pnlTambahBukuAdmin.Hide();
            this.pnlPeminjamanAdmin.Show();
            /*this.pnlPeminjamanAdmin.Dock = DockStyle.Bottom;*/
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();

        }

        private void btKelolaBukuAdmin_Click(object sender, EventArgs e)
        {
            btKelolaBuku.BackColor = Color.Black;
            btPeminjaman.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjaman.BackColor = Color.CornflowerBlue;
            btProfileAdmin.BackColor = Color.CornflowerBlue;
            btKeluarAdmin.BackColor = Color.CornflowerBlue;
            this.pnlTambahBukuAdmin.Hide();
            this.pnlDaftarBukuAdmin.Show();
            /*this.pnlDaftarBukuAdmin.Dock = DockStyle.Bottom;*/
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();
        }

        private void controlBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsernameAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btKeluarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTambahBukuAdmin_Click(object sender, EventArgs e)
        {
            this.pnlTambahBukuAdmin.Show();
            this.pnlDaftarBukuAdmin.Hide();
            /*this.pnlTambahBukuAdmin.Dock = DockStyle.Bottom;*/
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();
        }

        private void cbPenerbit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btTBAdmin_Click(object sender, EventArgs e)
        {

        }

        private void ucPenulisTambahBukuAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxVektoradmin_Click(object sender, EventArgs e)
        {

        }

        private void pnlTambahBukuAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void V_Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }



}
