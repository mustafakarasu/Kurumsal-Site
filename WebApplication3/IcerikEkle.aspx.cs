using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class IcerikEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                KurumsalContext ctx = new KurumsalContext();
                Icerik i = new Icerik();

                i.Baslik = Request.Form["baslik"];
                i.Makale = Request.Form["makale"];

                ctx.Icerikler.Add(i);
                ctx.SaveChanges();
            }
        }
    }
}