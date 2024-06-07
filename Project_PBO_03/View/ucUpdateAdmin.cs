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
    public partial class ucUpdateAdmin : UserControl
    {
        private object ucUpdateAdmin1;

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

        }
    }
}
