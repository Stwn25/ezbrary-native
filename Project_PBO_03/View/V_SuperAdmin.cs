using Project_PBO_03.Context;
using Project_PBO_03.Model;
using System;
using System.Drawing;
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
            pnlUserSA.Show();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Hide();
            ucUpdateAdmin1.Hide(); // Pastikan kontrol di-hide pada awalnya

            dataGridView1.DataSource = AdminContext.all();
            dataGridView2.DataSource = PenggunaContext.all();

            // Hapus kolom "Hapus" yang ada jika sebelumnya telah ditambahkan
            if (dataGridView2.Columns.Contains("HapusUser"))
            {
                dataGridView2.Columns.Remove("HapusUser");
            }

            if (dataGridView1.Columns.Contains("HapusAdmin"))
            {
                dataGridView1.Columns.Remove("HapusAdmin");
            }

            if (dataGridView1.Columns.Contains("UpdateAdmin"))
            {
                dataGridView1.Columns.Remove("UpdateAdmin");
            }

            // Tambahkan kolom tombol hapus ke dataGridView2 di sebelah kiri
            DataGridViewButtonColumn hapusUser = new DataGridViewButtonColumn
            {
                Name = "HapusUser",
                HeaderText = "Hapus User",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            dataGridView2.Columns.Insert(0, hapusUser);

            // Tambahkan kolom tombol hapus ke dataGridView1 di sebelah kiri
            DataGridViewButtonColumn hapusAdmin = new DataGridViewButtonColumn
            {
                Name = "HapusAdmin",
                HeaderText = "Hapus Admin",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(0, hapusAdmin);

            // Tambahkan kolom tombol update ke dataGridView1 di sebelah kiri
            DataGridViewButtonColumn updateAdmin = new DataGridViewButtonColumn
            {
                Name = "UpdateAdmin",
                HeaderText = "Update Admin",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(1, updateAdmin);

            // Tambahkan event handler untuk DataGridView2 Cell Content Click
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;

            // Tambahkan event handler untuk DataGridView1 Cell Content Click
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }


        private void btKelolaAkunSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            pnlUserSA.Show();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Hide();
        }

        private void btUserSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.Black;
            btUserSA1.BackColor = Color.Black;
            btAdminSA.BackColor = Color.CornflowerBlue;
            btAdminSA1.BackColor = Color.CornflowerBlue;
            pnlUserSA.Show();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Hide();
        }

        private void btAdminSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.CornflowerBlue;
            btAdminSA.BackColor = Color.Black;
            btAdminSA1.BackColor = Color.Black;
            pnlUserSA.Hide();
            pnlAdminSA.Show();
            pnlDaftarAdminSA.Hide();
        }

        private void btUserSA1_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.Black;
            btUserSA.BackColor = Color.Black;
            btAdminSA1.BackColor = Color.CornflowerBlue;
            btAdminSA.BackColor = Color.CornflowerBlue;
            pnlUserSA.Show();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Hide();
        }

        private void btAdminSA1_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            btUserSA1.BackColor = Color.CornflowerBlue;
            btUserSA.BackColor = Color.CornflowerBlue;
            btAdminSA1.BackColor = Color.Black;
            btAdminSA.BackColor = Color.Black;
            pnlUserSA.Hide();
            pnlAdminSA.Show();
            pnlDaftarAdminSA.Hide();
        }

        private void btDaftarSA_Click(object sender, EventArgs e)
        {
            btKelolaAkunSA.BackColor = Color.Black;
            btKeluarSA.BackColor = Color.CornflowerBlue;
            pnlUserSA.Hide();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Show();
            pnlDaftarAdminSA.Dock = DockStyle.Bottom;
        }

        private void btKeluarSA_Click(object sender, EventArgs e)
        {
            V_Login login = new V_Login();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["HapusAdmin"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int idadmin = Convert.ToInt32(row.Cells["idadmin"].Value);
                AdminContext.delete(idadmin);
                dataGridView1.DataSource = AdminContext.all();
                MessageBox.Show("Admin berhasil dihapus!", "Sukses", MessageBoxButtons.OK);
            }

            if (e.ColumnIndex == dataGridView1.Columns["UpdateAdmin"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int idadmin = Convert.ToInt32(row.Cells["idadmin"].Value);

                // Load the admin data into the UserControl
                ucUpdateAdmin1.LoadAdminData(idadmin);

                // Ensure the UserControl is visible and brought to the front
                ucUpdateAdmin1.BringToFront();
                ucUpdateAdmin1.Show();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["HapusUser"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                int iduser = Convert.ToInt32(row.Cells["iduser"].Value);
                PenggunaContext.delete(iduser);
                dataGridView2.DataSource = PenggunaContext.all();
                MessageBox.Show("User berhasil dihapus!", "Sukses", MessageBoxButtons.OK);
            }
        }

        private void btDaftarAdminSA_Click(object sender, EventArgs e)
        {
            pnlUserSA.Hide();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Show();
            pnlDaftarAdminSA.Dock = DockStyle.Bottom;
        }

        private void pnlDaftarAdminSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucUpdateAdmin1_Load(object sender, EventArgs e)
        {
            this.ucUpdateAdmin1.Hide();

        }
    }
}
