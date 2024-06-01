using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO_03.Model
{
    internal class m_Penulis
    {
        [Key]
        public string id_penulis { get; set; }
        [Required]
        public string nama_penulis { get; set; }

    }
}