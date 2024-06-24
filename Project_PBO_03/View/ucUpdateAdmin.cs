using Project_PBO_03.Context;
using Project_PBO_03.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_PBO_03.View
{
    public partial class ucUpdateAdmin : UserControl
    {
        public int IdAdmin { get; set; }

        public event EventHandler UpdateAdminSuccess;

        public ucUpdateAdmin()
        {
            InitializeComponent();
        }

        public void LoadAdminData(int idadmin)
        {
            DataTable dt = AdminContext.read(idadmin);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbUsernameSAuc.Text = row["usrnmeadmin"].ToString();
                tbNamaSAuc.Text = row["namaadmin"].ToString();
                tbEmailSAuc.Text = row["emailadmin"].ToString();
                tbTeleponSAuc.Text = row["telpadmin"].ToString();
                tbPasswordSAuc.Text = row["pwadmin"].ToString();
                tbKodeVSAuc.Text = row["kodeverifikasi"].ToString();
            }
        }

        private void ucUpdateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btUpdateSAuc_Click(object sender, EventArgs e)
        {
            if (IdAdmin != 0)
            {
                DataTable dt = AdminContext.read(IdAdmin);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    m_Administrator updatedAdmin = new m_Administrator
                    {
                        id_admin = IdAdmin,
                        kode_verif = tbKodeVSAuc.Text,
                        username_admin = tbUsernameSAuc.Text,
                        nama_admin = tbNamaSAuc.Text,
                        email_admin = tbEmailSAuc.Text,
                        telp_admin = tbTeleponSAuc.Text,
                        pass_admin = tbPasswordSAuc.Text
                    };

                    try
                    {
                        AdminContext.update(updatedAdmin);
                        MessageBox.Show("Data admin berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateAdminSuccess?.Invoke(this, EventArgs.Empty);

                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memperbarui data admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data admin tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Admin tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
