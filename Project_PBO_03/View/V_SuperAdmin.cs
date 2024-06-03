using Project_PBO_03.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO_03.View
{
    public partial class V_SuperAdmin : Form
    {
        public V_SuperAdmin()
        {
            InitializeComponent();
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.Black;
            btUserSA1.BackColor = Color.Black;
            btAdminSA.BackColor = Color.CornflowerBlue;
            btAdminSA1.BackColor = Color.CornflowerBlue;
            this.pnlUserSA.Show();
            /*            this.pnlUserSA.Dock = DockStyle.Bottom;*/
            this.pnlAdminSA.Hide();
            this.pnlDaftarAdminSA.Hide();
            dataGridView1.DataSource = PenggunaContext.all();
            dataGridView2.DataSource = AdminContext.all();
        }

        private void btKelolaAkunSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            this.pnlUserSA.Show();
            /*            this.pnlUserSA.Dock = DockStyle.Bottom;*/
            this.pnlAdminSA.Hide();
            this.pnlDaftarAdminSA.Hide();
        }

        private void btUserSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.Black;
            btUserSA1.BackColor = Color.Black;
            btAdminSA.BackColor = Color.CornflowerBlue;
            btAdminSA1.BackColor = Color.CornflowerBlue;
            this.pnlUserSA.Show();
            /*            this.pnlUserSA.Dock = DockStyle.Bottom;*/
            this.pnlAdminSA.Hide();
            this.pnlDaftarAdminSA.Hide();
        }

        private void btAdminSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.CornflowerBlue;
            btAdminSA.BackColor = Color.Black;
            btAdminSA1.BackColor = Color.Black;
            this.pnlUserSA.Hide();
            this.pnlAdminSA.Show();
            /*            this.pnlAdminSA.Dock = DockStyle.Bottom;*/
            this.pnlDaftarAdminSA.Hide();
        }

        private void btUserSA1_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.Black;
            btUserSA.BackColor = Color.Black;
            btAdminSA1.BackColor = Color.CornflowerBlue;
            btAdminSA.BackColor = Color.CornflowerBlue;
            this.pnlUserSA.Show();
            /*this.pnlUserSA.Dock = DockStyle.Bottom;*/
            this.pnlAdminSA.Hide();
            this.pnlDaftarAdminSA.Hide();
        }

        private void btAdminSA1_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.CornflowerBlue;
            btAdminSA1.BackColor = Color.Black;
            btAdminSA.BackColor = Color.Black;
            this.pnlUserSA.Hide();
            this.pnlAdminSA.Show();
            /*            this.pnlAdminSA.Dock = DockStyle.Bottom;*/
            this.pnlDaftarAdminSA.Hide();
        }

        private void btDaftarSA_Click(object sender, EventArgs e)
        {

        }

        private void btDaftarAdminSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            this.pnlUserSA.Hide();
            this.pnlAdminSA.Hide();
            this.pnlDaftarAdminSA.Show();
            this.pnlDaftarAdminSA.Dock = DockStyle.Bottom;
        }

        private void V_SuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btKeluarSA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDaftarAdminSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAdminSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
