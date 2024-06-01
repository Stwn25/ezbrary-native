using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_Pengguna
    {
        [Key]
        public int id_pengguna { get; set; }
        [Required]
        public string nama_pengguna { get; set; }
        public string username_pengguna { get; set; }
        public string pass_pengguna { get; set; }
        public string telp_pengguna { get; set; }
        public string email_pengguna { get; set; }
    }
}
