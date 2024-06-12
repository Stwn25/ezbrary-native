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
        private string input;
        public int idadmin;
        public V_Admin(string getnama)
        {
            InitializeComponent();
            this.input = getnama;
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
            cbJenisBukuAdmin.Text = default;

            cbPenerbit.DataSource = PenerbitContext.comboBox();
            cbPenerbit.DisplayMember = "namapenerbit";
            cbPenerbit.ValueMember = "idpenerbit";

            cbPenulis.DataSource = PenulisContext.all();
            cbPenulis.DisplayMember = "namapenulis";
            cbPenulis.ValueMember = "idpenulis";

            cbJenisBuku.DataSource = JenisBukuContext.all();
            cbJenisBuku.DisplayMember = "namajenis";
            cbJenisBuku.ValueMember = "idjenis";

            /*MessageBox.Show($"Admin : {input}", "Plis", MessageBoxButtons.OK);*/
            /*V_Login login = new V_Login();*/


            DataTable dt = AdminContext.dataadmin(input);
            if (dt != null && input != null)
            {
                MessageBox.Show($"Admin : {input}", "Plis", MessageBoxButtons.OK);

                int idadmins = Convert.ToInt32(dt.Rows[0]["idadmin"]);
                string namaadmin = dt.Rows[0]["namaadmin"].ToString();
                string telpadmin = dt.Rows[0]["telpadmin"].ToString();
                string usrnmeadmin = dt.Rows[0]["usrnmeadmin"].ToString();
                string pwadmin = dt.Rows[0]["pwadmin"].ToString();
                string emailadmin = dt.Rows[0]["emailadmin"].ToString();
                idadmin = idadmins;

                MessageBox.Show($"Admin : {idadmin}", "Plis", MessageBoxButtons.OK);

                tbNamaProfileAdmin.Text = namaadmin;
                tbUsernameAdmin.Text = usrnmeadmin;
                btPasswordProfileAdmin.Text = pwadmin;
                tbNoTeleponProfileAdmin.Text = telpadmin;
                tbEmailProfileAdmin.Text = emailadmin;
                lblGmail.Text = emailadmin;
                lblUsername.Text = usrnmeadmin;
                lblhai1Admin.Text = usrnmeadmin;
            }
            else
            {
                MessageBox.Show($"Admin : {input}", "Plis", MessageBoxButtons.OK);
            }


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
            string namajenis = Convert.ToString(cbJenisBukuAdmin.SelectedValue);
            dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(namajenis);

            try
            {
                // Pengecekan input kosong
                if (string.IsNullOrWhiteSpace(tbISBN.Text) ||
                    string.IsNullOrWhiteSpace(tbNamaBuku.Text) ||
                    string.IsNullOrWhiteSpace(tbSinopsisBuku.Text) ||
                    string.IsNullOrWhiteSpace(tbTahunTerbit.Text) ||
                    string.IsNullOrWhiteSpace(tbStokBuku.Text) ||
                    cbJenisBuku.SelectedItem == null ||
                    cbPenerbit.SelectedItem == null ||
                    cbPenulis.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(tbPosisiRak.Text))
                {
                    MessageBox.Show("Tidak boleh ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mendapatkan data dari combobox
                DataRowView rowJenisBuku = cbJenisBuku.SelectedItem as DataRowView;
                DataRowView rowPenerbit = cbPenerbit.SelectedItem as DataRowView;
                DataRowView rowPenulis = cbPenulis.SelectedItem as DataRowView;

                // Membuat objek buku baru
                m_Buku tambahBuku = new m_Buku
                {
                    isbn = tbISBN.Text,
                    nama_buku = tbNamaBuku.Text,
                    sinopsis = tbSinopsisBuku.Text,
                    thn_terbit = tbTahunTerbit.Text,
                    jenis_id = Convert.ToInt32(rowJenisBuku["idjenis"]),
                    stok_buku = Convert.ToInt32(tbStokBuku.Text),
                    penerbit_id = Convert.ToInt32(rowPenerbit["idpenerbit"]),
                    penulis_id = Convert.ToInt32(rowPenulis["idpenulis"]),
                    posisi_rak = tbPosisiRak.Text
                };

                // Menambahkan buku baru ke database
                BukuContext.create(tambahBuku);

                // Menampilkan pesan sukses
                DialogResult message = MessageBox.Show("Data buku berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membersihkan textbox dan combobox
                if (message == DialogResult.OK)
                {
                    tbISBN.Clear();
                    tbNamaBuku.Clear();
                    tbSinopsisBuku.Clear();
                    tbTahunTerbit.Clear();
                    tbStokBuku.Clear();
                    tbPosisiRak.Clear();
                    cbJenisBuku.SelectedIndex = -1;
                    cbPenerbit.SelectedIndex = -1;
                    cbPenulis.SelectedIndex = -1;

                    // Memperbarui data di dataGridView
                    dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(namajenis);
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error
                MessageBox.Show("Gagal menambahkan data buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbJenisBukuAdmin.DataSource = JenisBukuContext.comboBox();

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
            int idstatus = Convert.ToInt32(dgvDaftarBuku.Rows[e.RowIndex].Cells["statusbuku_idstatusbuku"].Value);

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

            if (e.ColumnIndex == dgvDaftarBuku.Columns["statusButton"].Index && e.RowIndex >= 0)
            {
                if (idstatus == 1)
                {
                    DialogResult message = MessageBox.Show("Apakah anda yakin ingin menonaktifkan buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        BukuContext.nonaktif(isbn);
                        DialogResult messageHapus = MessageBox.Show("Buku berhasil dinonaktifkan", "Sukses", MessageBoxButtons.OK);
                    }
                }

                else
                {
                    DialogResult message = MessageBox.Show("Apakah anda yakin ingin mengaktifkan buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        BukuContext.aktif(isbn);
                        DialogResult messageHapus = MessageBox.Show("Buku berhasil diaktifkan", "Sukses", MessageBoxButtons.OK);
                    }
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
                    dgvDaftarBuku.DataSource = JenisBukuContext.Jenis(jenisBuku);
                }
                else
                {
                    dgvDaftarBuku.DataSource = BukuContext.all();
                }

            }
        }

        private void ucUpdateBuku1_Load(object sender, EventArgs e)
        {

        }

        private void ucPenulisTambahBukuAdmin2_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlRiwayatPeminjaman_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsernameProfileAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tbNamaProfileAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPasswordProfileAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNoTeleponProfileAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmailProfileAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblGmail_Click(object sender, EventArgs e)
        {

        }

        private void lblhai1Admin_Click(object sender, EventArgs e)
        {

        }
    }



}
