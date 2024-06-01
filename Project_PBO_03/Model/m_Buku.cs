using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_Buku
    {
        [Key]
        public string isbn { get; set; }
        [Required]
        public string nama_buku { get; set; }
        public string sinopsis { get; set; }
        public string thn_terbit { get; set; }
        public int stok_buku { get; set; }
        public string jenis_buku { get; set; }
        public int penerbit_id { get; set; }
        public int penulis_id { get; set; }
    }
}
