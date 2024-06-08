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

        }

        private void btSimpanPenerbit_Click(object sender, EventArgs e)
        {
            string Penerbit = tbNamaPenerbit.Text;
            string Alamat = tbAlamatPenerbit.Text;

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
