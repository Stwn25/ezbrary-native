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

        }

        private void btSimpanPenulis_Click(object sender, EventArgs e)
        {
            {
                string Penulis = tbNamaPenulis.Text;

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
        }

        private void tbNamaPenulis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
