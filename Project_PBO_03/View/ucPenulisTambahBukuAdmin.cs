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
    public partial class ucPenulisTambahBukuAdmin : UserControl
    {
        public ucPenulisTambahBukuAdmin()
        {
            InitializeComponent();
            dgvPenulis.DataSource = PenulisContext.all();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvPenulis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idpenulis = Convert.ToInt32(dgvPenulis.Rows[e.RowIndex].Cells["idpenulis"].Value);

            if (e.ColumnIndex == dgvPenulis.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa tetapi konfirmasi dulu
                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    PenulisContext.delete(idpenulis);
                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                dgvPenulis.DataSource = null;
                dgvPenulis.DataSource = PenulisContext.all();
            }
        }

        private void btSimpanPenulis_Click(object sender, EventArgs e)
        {
            string Penulis = tbNamaPenulis.Text;
            // Pengecekan input kosong
            if (string.IsNullOrWhiteSpace(tbNamaPenulis.Text))
            {
                MessageBox.Show("Tidak boleh ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_Penulis penulisBaru = new m_Penulis()
                {
                nama_penulis = Penulis,
            };

            PenulisContext.create(penulisBaru);
            DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                dgvPenulis.DataSource = PenulisContext.all();
                tbNamaPenulis.Text = default;
            }
        }

        private void tbNamaPenulis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
