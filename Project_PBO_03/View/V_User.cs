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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Project_PBO_03
{
    public partial class V_User : Form
    {
        private string input;
        private int idpengguna;
        DateTime currentDate = DateTime.Now.Date;
        private string isbn1;
        private string judul1;
        private string sinopsis1;
        private string thnTerbit1;
        private string jenis1;
        private int stok1;
        private string penerbit1;
        private string penulis1;
        private string posisiRak1;
        private string username1;

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
            this.pnlDetailBuku.Hide();
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
                    int stokbuku = Int32.Parse(dataRow["stokbuku"].ToString());
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

        public void UpdateDetail(string isbn, string judul, string sinopsis, string thnTerbit, string jenis, int stok, string penerbit, string penulis, string posisiRak, string username)
        {
            this.isbn1 = isbn;
            this.judul1 = judul;
            this.sinopsis1 = sinopsis;
            this.thnTerbit1 = thnTerbit;
            this.jenis1 = jenis;
            this.stok1 = stok;
            this.penerbit1 = penerbit;
            this.penulis1 = penulis;
            this.posisiRak1 = posisiRak;
            this.username1 = username;

            isbnBuku.Text = isbn1;
            namabuku.Text = $"Judul: {judul1}";
            tbSinopsis.Text = $"Sinopsis: {sinopsis1}";
            lbtahunterbit.Text = $"Tahun Terbit: {thnTerbit1}";
            lbjenisbuku.Text = $"Jenis Buku: {jenis1}";
            lbstok.Text = $"Stok: {stok1}";
            lbpenerbit.Text = $"Penerbit: {penerbit1}";
            lbpenulis.Text = $"Penulis: {penulis1}";
            lbposisirak.Text = $"Posisi Rak: {posisiRak1}";
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
                BukuContext.kurangistok(isbn1);

                MessageBox.Show($"Booking buku berhasil, jangan lupa ambil buku sesuai tanggal pengambilan", "Berhasil", MessageBoxButtons.OK);
                if (message == DialogResult.OK)
                {
                    this.pnlDetailBuku.Hide();
                    dgvPeminjamanUser.DataSource = BukuContext.buku();

                    /*this.pnlDetailBuku.Show();
                    UpdateDetail(isbn1, judul1, sinopsis1, thnTerbit1, jenis1, stok1, penerbit1, penulis1, posisiRak1, input);*/
                }
            }
        }

        private void btSimpanPerubahanU_Click(object sender, EventArgs e)
        {
            if (idpengguna != 0)
            {
                DataTable dt = PenggunaContext.read(idpengguna.ToString(), false); // Memanggil metode read dengan ID
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    m_Pengguna updatedPengguna = new m_Pengguna
                    {
                        id_pengguna = idpengguna,
                        username_pengguna = tbUsernameProfileU.Text,
                        nama_pengguna = tbNamaProfileU.Text,
                        email_pengguna = tbEmailU.Text,
                        telp_pengguna = tbTeleponU.Text,
                        pass_pengguna = tbPassU.Text
                    };

                    try
                    {
                        PenggunaContext.update(updatedPengguna);
                        MessageBox.Show("Data anda berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.pnlProfileUser.Show();

                        lblEmailUser.Text = tbEmailU.Text;
                        lblHai1User.Text = tbUsernameProfileU.Text;
                        lblUsernameUser.Text = tbUsernameProfileU.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memperbarui data anda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data anda tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID anda tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
