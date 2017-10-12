using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class IcerikGoster : System.Web.UI.Page
    {
        public string baslik = "";
        public string icerik = "";

        //public Models.Icerik Icerik = new Models.Icerik();
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelenid = Request.QueryString["ID"];
            if (string.IsNullOrEmpty(gelenid))
            {
                //Ne gösterileceği belli değil.
                baslik = "Sayfa bulunamadı.";
                icerik = "ID parametresini göndermediğiniz için hangi içeriği göstereceğimizi bilmiyoruz.";
            }
            else
            {
                int id = Convert.ToInt32(gelenid);
                KurumsalContext ctx = new KurumsalContext();
                var yazi = ctx.Icerikler.Find(id);
                baslik = yazi.Baslik;
                icerik = yazi.Makale;
            }
        }
    }
}