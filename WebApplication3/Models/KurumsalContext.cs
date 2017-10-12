using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class KurumsalContext :DbContext
    {
        public virtual DbSet<Ayar> Ayarlar { get; set; }
        public virtual DbSet<Referans> Referanslar { get; set; }
        public virtual DbSet<Iletisim> Iletisimler { get; set; }
        public virtual DbSet<Icerik> Icerikler { get; set; }
    }
}
