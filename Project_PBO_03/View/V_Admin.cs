using Npgsql;
using NpgsqlTypes;
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
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();

            ucJenisBukuTambahBukuAdmin1.Hide();
            ucPenerbitTambahBukuAdmin1.Hide();
            ucPenulisTambahBukuAdmin2.Hide();
            ucUpdateBuku1.Hide();

            dgvDaftarBuku.DataSource = BukuContext.all();
            cbJenisBukuAdmin.DataSource = JenisBukuContext.comboBox();
            cbJenisBukuAdmin.DisplayMember = "namajenis";
            cbJenisBukuAdmin.ValueMember = "namajenis";
            cbJenisBukuAdmin.Text = "All";

            cbPenerbit.DataSource = PenerbitContext.comboBox();
            cbPenerbit.DisplayMember = "namapenerbit";
            cbPenerbit.ValueMember = "idpenerbit";

            cbPenulis.DataSource = PenulisContext.all();
            cbPenulis.DisplayMember = "namapenulis";
            cbPenulis.ValueMember = "idpenulis";

            cbJenisBuku.DataSource = JenisBukuContext.all();
            cbJenisBuku.DisplayMember = "namajenis";
            cbJenisBuku.ValueMember = "idjenis";

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

            string namajenis = Convert.ToString(cbJenisBukuAdmin.SelectedValue);
            dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(namajenis);
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
            this.pnlPeminjamanAdmin.Hide();
            this.pnlRiwayatPeminjaman.Hide();
            this.pnlProfileAdmin.Hide();

            cbPenerbit.DataSource = PenerbitContext.comboBox();
            cbPenerbit.DisplayMember = "namapenerbit";
            cbPenerbit.ValueMember = "idpenerbit";

            cbPenulis.DataSource = PenulisContext.all();
            cbPenulis.DisplayMember = "namapenulis";
            cbPenulis.ValueMember = "idpenulis";

            cbJenisBuku.DataSource = JenisBukuContext.all();
            cbJenisBuku.DisplayMember = "namajenis";
            cbJenisBuku.ValueMember = "idjenis";
        }



        private void btTBAdmin_Click(object sender, EventArgs e)
        {
            dgvDaftarBuku.Columns[9].HeaderText = "Hapus";

            DataRowView rowJenisBuku = cbJenisBuku.SelectedItem as DataRowView;
            DataRowView rowPenerbit = cbPenerbit.SelectedItem as DataRowView;
            DataRowView rowPenulis = cbPenulis.SelectedItem as DataRowView;

            string isbn = tbISBN.Text;
            string namabuku = tbNamaBuku.Text;
            string sinopsis = tbSinopsisBuku.Text;
            string tahunterbit = tbTahunTerbit.Text;
            int jenisbuku = Convert.ToInt32(rowJenisBuku["idjenis"]);
            int stokbuku = Convert.ToInt32(tbStokBuku.Text);
            int penerbit = Convert.ToInt32(rowPenerbit["idpenerbit"]);
            int penulis = Convert.ToInt32(rowPenulis["idpenulis"]);
            string posisirak = tbPosisiRak.Text;

            m_Buku tambahBuku = new m_Buku
            {
                isbn = isbn,
                nama_buku = namabuku,
                sinopsis = sinopsis,
                thn_terbit = tahunterbit,
                jenis_id = jenisbuku,
                stok_buku = stokbuku,
                penerbit_id = penerbit,
                penulis_id = penulis,
                posisi_rak = posisirak
            };

            BukuContext.create(tambahBuku);
            DialogResult message = MessageBox.Show("Data buku berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                tbISBN.Text = default;
                tbNamaBuku.Text = default;
                tbSinopsisBuku.Text = default;
                tbTahunTerbit.Text = default;
                tbPosisiRak.Text = default;
                tbStokBuku.Text = default;

                string namajenis = Convert.ToString(cbJenisBukuAdmin.SelectedValue);
                dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(namajenis);
            }

        }

        private void cbJenisBuku_SelectionChangeCommitted(object sender, EventArgs e)
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

        private void ucJenisBukuTambahBukuAdmin2_Load(object sender, EventArgs e)
        {

        }

        private void btPenerbit_Click(object sender, EventArgs e)
        {
            ucPenerbitTambahBukuAdmin1.Show();
            ucPenulisTambahBukuAdmin2.Hide();
            ucJenisBukuTambahBukuAdmin1.Hide();
        }

        private void ucJenisBukuTambahBukuAdmin1_Load(object sender, EventArgs e)
        {
            
        }

        private void btJenisBuku_Click(object sender, EventArgs e)
        {
            ucJenisBukuTambahBukuAdmin1.Show();
            ucPenulisTambahBukuAdmin2.Hide();
            ucPenerbitTambahBukuAdmin1.Hide();
        }

        private void btPenulis_Click(object sender, EventArgs e)
        {
            ucPenulisTambahBukuAdmin2.Show();
            ucJenisBukuTambahBukuAdmin1.Hide();
            ucPenerbitTambahBukuAdmin1.Hide();
        }


        private void ucPenerbitTambahBukuAdmin1_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ucPenulisTambahBukuAdmin2_Load(object sender, EventArgs e)
        {

        }

        private void dgvDaftarBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string namajenis = Convert.ToString(cbJenisBukuAdmin.SelectedValue);
            string isbn = Convert.ToString(dgvDaftarBuku.Rows[e.RowIndex].Cells["isbn"].Value);

            if (e.ColumnIndex == dgvDaftarBuku.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa tetapi konfirmasi dulu
                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    BukuContext.delete(isbn);
                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                dgvDaftarBuku.DataSource = null;
                dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(namajenis);
            }
            if (e.ColumnIndex == dgvDaftarBuku.Columns["updateButton"].Index && e.RowIndex >= 0)
            {
                ucUpdateBuku1.Show();
            }
        }
        public void cbPenerbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPenerbit.SelectedIndex != null)
            {
                DataRowView selectedRow = cbPenerbit.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    string namapenerbit = selectedRow["namapenerbit"].ToString();
                    int idpenerbit = Convert.ToInt32(selectedRow["idpenerbit"]);
                }
            }
        }

        public void cbPenulis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPenulis.SelectedItem != null)
            {
                // Dapatkan DataRowView dari item yang dipilih
                DataRowView selectedRow = cbPenulis.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    // Akses nilai dari DataRowView
                    string namaPenulis = selectedRow["namapenulis"].ToString();
                    int idPenulis = Convert.ToInt32(selectedRow["idpenulis"]);
                }
            }
        }

        public void cbJenisBuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbJenisBukuAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJenisBuku.SelectedItem != null)
            {
                DataRowView selectedRow = cbJenisBukuAdmin.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    string jenisBuku = selectedRow["namajenis"].ToString();

                    if (jenisBuku == "All")
                    {
                        dgvDaftarBuku.DataSource = BukuContext.all();
                    }
                    else
                    {
                        dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(jenisBuku);
                    }

                }

            }
        }

        private void ucUpdateBuku1_Load(object sender, EventArgs e)
        {

        }

        private void ucPenulisTambahBukuAdmin2_Load_1(object sender, EventArgs e)
        {
            
        }
    }



}
