using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    [Table("tblIcerik")]
    public class Icerik
    {
        [Key]
        public int IcerikID { get; set; }
        public string Baslik { get; set; }
        public string Makale { get; set; }
    }
}
