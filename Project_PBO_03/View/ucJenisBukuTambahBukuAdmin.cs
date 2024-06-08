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

        }

        private void tbJenisBuku_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
