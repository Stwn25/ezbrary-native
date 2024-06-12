using Microsoft.VisualBasic.Logging;
using Npgsql;
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
    public partial class V_User : Form
    {
        private string input;
        private int idpengguna;
        DateTime currentDate = DateTime.Now.Date;

        public V_User(string input)
        {
            InitializeComponent();
            this.input = input;

            btPeminjamanUser.BackColor = Color.Black;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;

            this.pnlPeminjamanUser.Show();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            this.pnlDetailBuku.Hide();

            cbJenis.DataSource = JenisBukuContext.all();
            cbJenis.DisplayMember = "namajenis";
            cbJenis.ValueMember = "namajenis";



            dgvPeminjamanUser.DataSource = BukuContext.buku();

            DataTable dt = PenggunaContext.datauser(input);
            if (dt != null)
            {
                MessageBox.Show($"User : {input}", "Plis", MessageBoxButtons.OK);

                int iduser = Convert.ToInt32(dt.Rows[0]["iduser"]);
                string nama = dt.Rows[0]["namauser"].ToString();
                string usernameuser = dt.Rows[0]["usrnmeuser"].ToString();
                string pwuser = dt.Rows[0]["pwuser"].ToString();
                string telpuser = dt.Rows[0]["telpuser"].ToString();
                string email = dt.Rows[0]["emailuser"].ToString();
                idpengguna = iduser;

                MessageBox.Show($"User : {idpengguna}", "Plis", MessageBoxButtons.OK);

                tbNamaProfileU.Text = nama;
                tbUsernameProfileU.Text = usernameuser;
                tbPassU.Text = pwuser;
                tbTeleponU.Text = telpuser;
                tbEmailU.Text = email;
                lblEmailUser.Text = email;
                lblHai1User.Text = usernameuser;
                lblUsernameUser.Text = usernameuser;
            }
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

        }



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
            this.Close();
        }

        private void pnlPeminjamanUser_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxPerpusUser_Click(object sender, EventArgs e)
        {

        }

        private void V_User_Load(object sender, EventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namajenis = Convert.ToString(cbJenis.SelectedValue);

            if (cbJenis.SelectedValue != null)
            {
                dgvPeminjamanUser.DataSource = JenisBukuContext.comboBoxUser(namajenis);
            }
        }

        private void dgvPeminjamanUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvPeminjamanUser.Columns["detailBuku"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPeminjamanUser.Rows[e.RowIndex];
                string namabuku = row.Cells["namabuku"].Value.ToString();

                DataTable dataTable = BukuContext.detailbuku(namabuku);
                if (dataTable.Rows.Count > 0)
                {

                    DataRow dataRow = dataTable.Rows[0];
                    string isbn = dataRow["isbn"].ToString();
                    string Namabuku = dataRow["namabuku"].ToString();
                    string sinopsis = dataRow["sinopsis"].ToString();
                    string thnterbit = dataRow["thnterbit"].ToString();
                    string namajenis = dataRow["namajenis"].ToString();
                    string stokbuku = dataRow["stokbuku"].ToString();
                    string namapenerbit = dataRow["namapenerbit"].ToString();
                    string namapenulis = dataRow["namapenulis"].ToString();
                    string posisirak = dataRow["posisirak"].ToString();

                    this.pnlDetailBuku.Show();
                    UpdateDetail(isbn, Namabuku, sinopsis, thnterbit, namajenis, stokbuku, namapenerbit, namapenulis, posisirak, input);
                }
            }
        }

        private void ucDetailBukuUser1_Load(object sender, EventArgs e)
        {

        }

        private void tglPengambilanBooking_ValueChanged(object sender, EventArgs e)
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

        public void UpdateDetail(string isbn, string judul, string sinopsis, string thnTerbit, string jenis, string stok, string penerbit, string penulis, string posisiRak, string username)
        {
            isbnBuku.Text = isbn;
            namabuku.Text = $"Judul: {judul}";
            tbSinopsis.Text = $"Sinopsis: {sinopsis}";
            lbtahunterbit.Text = $"Tahun Terbit: {thnTerbit}";
            lbjenisbuku.Text = $"Jenis Buku: {jenis}";
            lbstok.Text = $"Stok: {stok}";
            lbpenerbit.Text = $"Penerbit: {penerbit}";
            lbpenulis.Text = $"Penulis: {penulis}";
            lbposisirak.Text = $"Posisi Rak: {posisiRak}";
        }

        public void pnlDetailBuku_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btkeluar_Click(object sender, EventArgs e)
        {
            this.pnlDetailBuku.Hide();
        }

        private void btBookingBuku_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show($"Pengambilan dilakukan pada tanggal {tglPengambilanBooking.Value},\ndan dikembalikan pada tanggal {tglPengambilanBooking.Value.AddDays(7)}", "Pemberitahuan", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                m_PeminjamanBuku peminjaman = new m_PeminjamanBuku
                {
                    isbn_buku = isbnBuku.Text,
                    tgl_pengambilan = tglPengambilanBooking.Value,
                    tgl_pengembalian = tglPengambilanBooking.Value.AddDays(7),
                    id_status = 1,
                    id_pengguna = idpengguna
                };

                PeminjamanBuku.create(peminjaman);
                MessageBox.Show($"Booking buku berhasil, jangan lupa ambil buku sesuai tanggal pengambilan", "Berhasil", MessageBoxButtons.OK);
            }
        }

        private void tbPeminjamanUser_TextChanged(object sender, EventArgs e)
        {
            string pencarian = tbPeminjamanUser.Text;
            DataTable search = BukuContext.showBySearch(pencarian);
            dgvPeminjamanUser.DataSource = search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pencarian = tbPeminjamanUser.Text;
            DataTable search = BukuContext.showBySearch(pencarian);
            dgvPeminjamanUser.DataSource = search;
        }
    }
}
