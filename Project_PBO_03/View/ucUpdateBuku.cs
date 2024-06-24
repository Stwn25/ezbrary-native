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

namespace Project_PBO_03.View
{
    public partial class ucUpdateBuku : UserControl
    {
        public string ISBN { get; set; }

        public event EventHandler UpdateBukuSuccess;


        public ucUpdateBuku()
        {
            InitializeComponent();
        }

        public void LoadDataBuku(string isbn)
        {
            this.ISBN = isbn;
            DataTable dataBuku = BukuContext.read(isbn);
            if (dataBuku.Rows.Count > 0)
            {
                DataRow row = dataBuku.Rows[0];
                tbISBNuc.Text = row["isbn"].ToString();
                tbNamaBukuuc.Text = row["namabuku"].ToString();
                tbSinopsisBukuuc.Text = row["sinopsis"].ToString();
                tbTahunTerbituc.Text = row["thnterbit"].ToString();
                tbStokBukuuc.Text = row["stokbuku"].ToString();
                tbPosisiRakuc.Text = row["posisirak"].ToString();

                cbPenerbituc.DataSource = PenerbitContext.all();
                cbPenerbituc.DisplayMember = "namapenerbit";
                cbPenerbituc.ValueMember = "idpenerbit";

                cbPenulisuc.DataSource = PenulisContext.all();
                cbPenulisuc.DisplayMember = "namapenulis";
                cbPenulisuc.ValueMember = "idpenulis";

                cbJenisBukuuc.DataSource = JenisBukuContext.all();
                cbJenisBukuuc.DisplayMember = "namajenis";
                cbJenisBukuuc.ValueMember = "idjenis";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucUpdateBuku_Load(object sender, EventArgs e)
        {

        }

        private void tbNamaBukuuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUpdateBuku_Click(object sender, EventArgs e)
        {
            if (ISBN != null)
            {
                DataTable dt = BukuContext.read(ISBN);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    m_Buku updatedBuku = new m_Buku
                    {
                        isbn = tbISBNuc.Text,
                        nama_buku = tbNamaBukuuc.Text,
                        sinopsis = tbSinopsisBukuuc.Text,
                        thn_terbit = tbTahunTerbituc.Text,
                        stok_buku = Convert.ToInt16(tbStokBukuuc.Text),
                        penerbit_id = Convert.ToInt16(cbPenerbituc.SelectedValue),
                        penulis_id = Convert.ToInt16(cbPenulisuc.SelectedValue),
                        jenis_id = Convert.ToInt16(cbJenisBukuuc.SelectedValue),
                        posisi_rak = tbPosisiRakuc.Text
                    };

                    try
                    {
                        BukuContext.update(updatedBuku, ISBN);
                        MessageBox.Show("Data buku berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UpdateBukuSuccess?.Invoke(this, EventArgs.Empty);
                        this.Hide();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memperbarui data buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Data buku tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ISBN buku tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
