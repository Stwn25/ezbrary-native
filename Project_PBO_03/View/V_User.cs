using Microsoft.VisualBasic.Logging;
using Npgsql;
using Project_PBO_03.Context;
using Project_PBO_03.Core;
using Project_PBO_03.View;
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
    public partial class V_User : Form
    {


        public V_User()
        {
            InitializeComponent();


            ucDetailBukuUser1.Hide();


            btPeminjamanUser.BackColor = Color.Black;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Show();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();
            cbJenis.DataSource = JenisBukuContext.all();
            cbJenis.DisplayMember = "namajenis";
            cbJenis.ValueMember = "namajenis";
            dgvPeminjamanUser.DataSource = BukuContext.buku();
            V_Login login = (V_Login)Application.OpenForms["V_Login"];
            if (login != null)
            {
                string data = "Host=localhost;Port=5432;Database=PROYEK PBO;User Id=postgres;Password=20juli2004";
                using (NpgsqlConnection conn = new NpgsqlConnection(data))
                {
                    conn.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM pengguna", conn))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                tbNamaProfileU.Text = reader["namauser"].ToString();
                                tbUsernameProfileU.Text = reader["usrnmeuser"].ToString();
                                tbPassU.Text = reader["pwuser"].ToString();
                                tbTeleponU.Text = reader["telpuser"].ToString();
                                tbEmailU.Text = reader["emailuser"].ToString();
                                lblEmailUser.Text = reader["emailuser"].ToString();
                                lblHai1User.Text = reader["usrnmeuser"].ToString();
                                lblUsernameUser.Text = reader["usrnmeuser"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Error: ");
                            }
                        }
                    }
                }
            }
        }

        private void btPeminjaman_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.Black;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Show();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();

        }

        private void btBukuFavUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.Black;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Show();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Hide();

        }

        private void btRiwayatPeminjamanUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.Black;
            btProfileUser.BackColor = Color.CornflowerBlue;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Show();
            this.pnlProfileUser.Hide();

        }

        private void btProfileUser_Click(object sender, EventArgs e)
        {
            btPeminjamanUser.BackColor = Color.CornflowerBlue;
            btBukuFavUser.BackColor = Color.CornflowerBlue;
            btRiwayatPeminjamanUser.BackColor = Color.CornflowerBlue;
            btProfileUser.BackColor = Color.Black;
            btKeluarUser.BackColor = Color.CornflowerBlue;
            this.pnlPeminjamanUser.Hide();
            this.pnlBukuFavUser.Hide();
            this.pnlRiwayatUser.Hide();
            this.pnlProfileUser.Show();

        }



        private void pnlProfileUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRiwayatUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBukuFavUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPeminjamanUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btKeluarUser_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlPeminjamanUser_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxPerpusUser_Click(object sender, EventArgs e)
        {

        }

        private void V_User_Load(object sender, EventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namajenis = Convert.ToString(cbJenis.SelectedValue);

            if (cbJenis.SelectedValue != null)
            {
                dgvPeminjamanUser.DataSource = JenisBukuContext.Jenis(namajenis);
            }
        }

        private void dgvPeminjamanUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPeminjamanUser.Rows[e.RowIndex];
                string namabuku = row.Cells["namabuku"].Value.ToString();

                DataTable dataTable = BukuContext.detailbuku(namabuku);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    string isbn = dataRow["isbn"].ToString();
                    string Namabuku = dataRow["namabuku"].ToString();
                    string sinopsis = dataRow["sinopsis"].ToString();
                    string thnterbit = dataRow["thnterbit"].ToString();
                    string namajenis = dataRow["namajenis"].ToString();
                    string stokbuku = dataRow["stokbuku"].ToString();
                    string namapenerbit = dataRow["namapenerbit"].ToString();
                    string namapenulis = dataRow["namapenulis"].ToString();
                    string posisirak = dataRow["posisirak"].ToString();

                    ucDetailBukuUser1.UpdateLabels(isbn, Namabuku, sinopsis, thnterbit, namajenis, stokbuku, namapenerbit, namapenulis, posisirak);
                    ucDetailBukuUser1.Show();

                }
            }
        }
    }
}
