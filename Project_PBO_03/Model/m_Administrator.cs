using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_Administrator
    {

        [Key]
        public int id_admin { get; set; }
        public string kode_verif { get; set; }
        public string nama_admin { get; set; }
        public string telp_admin { get; set; }
        public string username_admin { get; set; }
        public string pass_admin { get; set; }
        public string email_admin { get; set; }
    }
}
