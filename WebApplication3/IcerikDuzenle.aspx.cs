using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class IcerikDuzenle : System.Web.UI.Page
    {
        public Icerik icerik = new Icerik();
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["ID"]);
            KurumsalContext ctx = new KurumsalContext();
            icerik = ctx.Icerikler.Find(gelenid);

            if(IsPostBack)
            {
                icerik.Baslik = Request.Form["baslik"];
                icerik.Makale = Request.Form["makale"];
                ctx.Entry(icerik).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}