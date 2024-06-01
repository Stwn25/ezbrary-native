using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_Penerbit
    {
        [Key]
        public int id_penerbit { get; set; }
        [Required]
        public string nama_penerbit { get; set; }
        public string alamat_penerbit { get; set; }
    }
}
