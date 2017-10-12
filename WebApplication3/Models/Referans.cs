using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    [Table("tblReferans")]
    public class Referans
    {
        [Key]
        public int ReferansID { get; set; }
        public string AdSoyad { get; set; }
        public string Mesaj { get; set; }
    }
}
