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
    public partial class ucPenerbitTambahBukuAdmin : UserControl
    {
        public ucPenerbitTambahBukuAdmin()
        {
            InitializeComponent();
            dgvPenerbit.DataSource = PenerbitContext.all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvPenerbit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idpenerbit = Convert.ToInt32(dgvPenerbit.Rows[e.RowIndex].Cells["idpenerbit"].Value);

            if (e.ColumnIndex == dgvPenerbit.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa tetapi konfirmasi dulu
                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    PenerbitContext.delete(idpenerbit);
                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                dgvPenerbit.DataSource = null;
                dgvPenerbit.DataSource = PenerbitContext.all();
            }
        }

        private void btSimpanPenerbit_Click(object sender, EventArgs e)
        {
            string Penerbit = tbNamaPenerbit.Text;
            string Alamat = tbAlamatPenerbit.Text;
            // Pengecekan input kosong
            if (string.IsNullOrWhiteSpace(tbNamaPenerbit.Text)||
                string.IsNullOrWhiteSpace(tbAlamatPenerbit.Text))
            {
                MessageBox.Show("Tidak boleh ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_Penerbit Penerbitnew = new m_Penerbit()
            {
                nama_penerbit = Penerbit,
                alamat_penerbit = Alamat,
            };

            PenerbitContext.create(Penerbitnew);
            DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                dgvPenerbit.DataSource = PenerbitContext.all();
                tbNamaPenerbit.Text = default;
                tbAlamatPenerbit.Text= default;
            }



        }

        private void tbNamaPenerbit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
