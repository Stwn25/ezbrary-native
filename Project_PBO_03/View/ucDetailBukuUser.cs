using Project_PBO_03.Context;
using Project_PBO_03.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO_03.View
{
    public partial class ucDetailBukuUser : UserControl
    {
        public ucDetailBukuUser()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ucDetailBukuUser_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbpenulis_Click(object sender, EventArgs e)
        {

        }

        private void lbstok_Click(object sender, EventArgs e)
        {

        }

        private void lbisbnBuku_Click(object sender, EventArgs e)
        {

        }

        private void lbtahunterbit_Click(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(string isbn, string judul, string sinopsis, string thnTerbit, string jenis, string stok, string penerbit, string penulis, string posisiRak)
        {
            lbisbnBuku.Text = $"ISBN: {isbn}";
            namabuku.Text = $"Judul: {judul}";
            tbSinopsis.Text = $"Sinopsis: {sinopsis}";
            lbtahunterbit.Text = $"Tahun Terbit: {thnTerbit}";
            lbjenisbuku.Text = $"Jenis Buku: {jenis}";
            lbstok.Text = $"Stok: {stok}";
            lbpenerbit.Text = $"Penerbit: {penerbit}";
            lbpenulis.Text = $"Penulis: {penulis}";
            lbposisirak.Text = $"Posisi Rak: {posisiRak}";
        }

        private void btkeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string isbn = lbisbnBuku.Text;
            int idpengguna = 1;

            m_BukuFavorit Bukufavorit = new m_BukuFavorit()
            {
                isbn_buku = isbn,
                id_pengguna = idpengguna,
            };

            BukuContext.bukufavorit(Bukufavorit);
            DialogResult message = MessageBox.Show("Buku berhasil difavoritkan", "Sukses", MessageBoxButtons.OK);


        }

        private void lbisbnBuku_Click_1(object sender, EventArgs e)
        {

        }

        private void lbpenerbit_Click(object sender, EventArgs e)
        {

        }

        private void lbisbnBuku_Click_2(object sender, EventArgs e)
        {

        }
    }
}
