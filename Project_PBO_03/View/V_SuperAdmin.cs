﻿using Project_PBO_03.Context;
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
            ucUpdateAdmin1.Hide();

            dataGridView1.DataSource = AdminContext.all();
            dataGridView2.DataSource = PenggunaContext.all();
            ucUpdateAdmin1.UpdateAdminSuccess += UcUpdateAdmin1_UpdateAdminSuccess;
        }

        private void UcUpdateAdmin1_UpdateAdminSuccess(object sender, EventArgs e)
        {
            // Refresh DataGridView1
            dataGridView1.DataSource = AdminContext.all();
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
            try
            {
                // Pengecekan input kosong
                if (string.IsNullOrWhiteSpace(tbUsernameSA.Text) ||
                    string.IsNullOrWhiteSpace(tbNamaSA.Text) ||
                    string.IsNullOrWhiteSpace(tbEmailSA.Text) ||
                    string.IsNullOrWhiteSpace(tbTeleponSA.Text) ||
                    string.IsNullOrWhiteSpace(tbPasswordSA.Text) ||
                    string.IsNullOrWhiteSpace(tbKodeVerifikasi.Text))
                {
                    MessageBox.Show("Tidak boleh ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Membuat objek admin baru
                m_Administrator newAdmin = new m_Administrator
                {
                    kode_verif = tbKodeVerifikasi.Text,
                    username_admin = tbUsernameSA.Text,
                    nama_admin = tbNamaSA.Text,
                    email_admin = tbEmailSA.Text,
                    telp_admin = tbTeleponSA.Text,
                    pass_admin = tbPasswordSA.Text
                };

                // Menambahkan admin baru ke database
                AdminContext.create(newAdmin);

                // Memperbarui data di dataGridView
                dataGridView1.DataSource = AdminContext.all();

                // Membersihkan textbox
                ClearTextboxes();

                // Menampilkan pesan sukses
                MessageBox.Show("Data admin berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Menyembunyikan panel
                pnlDaftarAdminSA.Hide();
                pnlAdminSA.Show();

            }
            catch (Exception ex)
            {
                // Menampilkan pesan error
                MessageBox.Show("Gagal menambahkan data admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearTextboxes()
        {
            tbUsernameSA.Text = "";
            tbNamaSA.Text = "";
            tbEmailSA.Text = "";
            tbTeleponSA.Text = "";
            tbPasswordSA.Text = "";
            tbKodeVerifikasi.Text = "";
        }


        private void btKeluarSA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["HapusAdmin"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idadmin"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    AdminContext.delete(id);

                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);

                    dataGridView1.DataSource = AdminContext.all();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["UpdateAdmin"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int idadmin = Convert.ToInt32(row.Cells["idadmin"].Value);

                // Set IdAdmin property of user control
                ucUpdateAdmin1.IdAdmin = idadmin;

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
                int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["iduser"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    PenggunaContext.delete(id);

                    DialogResult messageHapus = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);

                    dataGridView2.DataSource = PenggunaContext.all();
                }
            }
        }

        private void btDaftarAdminSA_Click(object sender, EventArgs e)
        {
            pnlUserSA.Hide();
            pnlAdminSA.Hide();
            pnlDaftarAdminSA.Show();
        }

        private void pnlDaftarAdminSA_Paint(object sender, PaintEventArgs e)
        {

        }


        private void ucUpdateAdmin1_Load(object sender, EventArgs e)
        {
            this.ucUpdateAdmin1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlDaftarAdminSA.Hide();
            pnlAdminSA.Show();
        }
    }
}
