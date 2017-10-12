using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class bizeulasin : System.Web.UI.Page
    {
        public string sonuc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                try
                {
                    KurumsalContext ctx = new KurumsalContext();
                    Iletisim il = new Iletisim();
                    il.AdSoyad = Request.Form["AdSoyad"];
                    il.Telefon = Request.Form["Telefon"];
                    il.Mesaj = Request.Form["mesaj"];

                    ctx.Iletisimler.Add(il);
                    ctx.SaveChanges();
                    sonuc = "Başarıyla eklendi";
                }
                catch
                {
                    sonuc = "Bir hata oluştu.";
                }
               
            }
        }
    }
}