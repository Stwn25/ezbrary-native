using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_JenisBuku
    {
        [Key]
        public int id_jenis { get; set; }
        [Required]
        public string nama_jenis { get; set; }
    }
}
