using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_UlasanBuku
    {
        [Key]
        public int isbn_buku { get; set; }
        [Key]
        public int id_user { get; set; }
        public string ulasan { get; set; }
    }
}
