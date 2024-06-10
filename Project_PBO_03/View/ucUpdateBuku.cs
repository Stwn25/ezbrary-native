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
        public ucUpdateBuku()
        {
            InitializeComponent();
        }

        public void LoadDataBuku(string isbn)
        {
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

                cbPenerbituc.DataSource = PenerbitContext.comboBox();
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
    }
}
