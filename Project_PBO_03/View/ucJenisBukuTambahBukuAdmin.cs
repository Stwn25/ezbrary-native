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
    public partial class ucJenisBukuTambahBukuAdmin : UserControl
    {
        public ucJenisBukuTambahBukuAdmin()
        {
            InitializeComponent();
            dgvJenisBuku.DataSource = JenisBukuContext.all();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btSimpanJenisBuku_Click(object sender, EventArgs e)
        {
            string namanovel = tbJenisBuku.Text;


            m_JenisBuku jenisBaru = new m_JenisBuku()
            {
                nama_jenis = namanovel
            };

            JenisBukuContext.create(jenisBaru);
            DialogResult message = MessageBox.Show("Data berhasil ditambahkan", "Sukses", MessageBoxButtons.OK);
            if (message == DialogResult.OK)
            {
                dgvJenisBuku.DataSource = JenisBukuContext.all();
                tbJenisBuku.Text = default;
            }


        }

        private void dgvJenisBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idjenis = Convert.ToInt32(dgvJenisBuku.Rows[e.RowIndex].Cells["idjenis"].Value);

            if (e.ColumnIndex == dgvJenisBuku.Columns["hapusButton"].Index && e.RowIndex >= 0)
            {

                // Panggil metode destroy dari kelas M_Mahasiswa untuk menghapus mahasiswa tetapi konfirmasi dulu
                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    JenisBukuContext.delete(idjenis);
                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                // Kemudian, perbarui DataGridView dengan data yang telah diperbarui
                dgvJenisBuku.DataSource = null;
                dgvJenisBuku.DataSource = JenisBukuContext.all();
            }

        }

        private void tbJenisBuku_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
