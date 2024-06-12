using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_BukuFavorit
    {
        [Key]
        public string isbn_buku { get; set; }
        [Key]
        public int id_pengguna { get; set; }
        public int id_status { get; set; }
    }
}
