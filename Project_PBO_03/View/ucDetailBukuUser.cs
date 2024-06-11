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
        DateTime currentDate = DateTime.Now.Date;
        public int id_pengguna { get; set; }

        public ucDetailBukuUser()
        {
            InitializeComponent();
            pbStarKuning.Hide();

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
            tglPengambilanBooking.Value = currentDate;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pbStarKosong.Hide();
            pbStarKuning.Show();

            /*string isbn = lbisbnBuku.Text;
            int idpengguna = 1;

            m_BukuFavorit Bukufavorit = new m_BukuFavorit()
            {
                isbn_buku = isbn,
                id_pengguna = idpengguna,
            };

            BukuContext.bukufavorit(Bukufavorit);
            DialogResult message = MessageBox.Show("Buku berhasil difavoritkan", "Sukses", MessageBoxButtons.OK);*/


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

        private void tbSinopsis_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void materialMultiLineTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        public void tglPengambilanBooking_ValueChanged(object sender, EventArgs e)
        {
            DateTime bookingDate = tglPengambilanBooking.Value;

            if ((bookingDate - currentDate).TotalDays > 2)
            {
                MessageBox.Show("Tanggal pengambilan tidak boleh lebih dari dua hari dari hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tglPengambilanBooking.Value = currentDate;
                return;
            }
            if ((bookingDate - currentDate).TotalDays < 0)
            {
                MessageBox.Show("Tentukan tanggal pengambilan dengan tepat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tglPengambilanBooking.Value = currentDate;
                return;
            }

        }

        private void pbStarKuning_Click(object sender, EventArgs e)
        {
            pbStarKosong.Show();
            pbStarKuning.Hide();
        }

        private void btBookingBuku_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.id_pengguna}", "Pemberitahuan", MessageBoxButtons.YesNo);


            DialogResult message = MessageBox.Show($"Pengambilan dilakukan pada tanggal {tglPengambilanBooking.Value},\ndan dikembalikan pada tanggal {tglPengambilanBooking.Value.AddDays(7)}", "Pemberitahuan", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                m_PeminjamanBuku peminjaman = new m_PeminjamanBuku
                {
                    isbn_buku = lbisbnBuku.Text,
                    tgl_pengambilan = tglPengambilanBooking.Value,
                    tgl_pengembalian = tglPengambilanBooking.Value.AddDays(7),
                    id_status = 1,
                    id_pengguna = this.id_pengguna
                };

                PeminjamanBuku.create(peminjaman);
            }
        }
    }
}
