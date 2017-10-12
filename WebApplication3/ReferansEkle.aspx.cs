using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class ReferansEkle : System.Web.UI.Page
    {
        public Referans r = new Referans();
        public bool ekle = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            KurumsalContext ctx = new KurumsalContext();
            
            var gelenid = Request.QueryString["ID"];
            if (!string.IsNullOrEmpty(gelenid))
            {
                r = ctx.Referanslar.Find(Convert.ToInt32(gelenid));
                ekle = false;
            }

            if (IsPostBack)
            {
                r.AdSoyad = Request.Form["adsoyad"];
                r.Mesaj = Request.Form["mesaj"];

                if(ekle)
                {
                    ctx.Referanslar.Add(r);                   
                }
                else
                {
                    ctx.Entry(r).State = System.Data.Entity.EntityState.Modified;
                }
                ctx.SaveChanges();
            }
        }
    }
}