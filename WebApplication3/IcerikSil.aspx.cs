using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class IcerikSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelenid = Request.QueryString["ID"];

            KurumsalContext ctx = new KurumsalContext();
            Icerik i = ctx.Icerikler.Find(Convert.ToInt32(gelenid));
            ctx.Icerikler.Remove(i);
            ctx.SaveChanges();

            Response.Redirect("/Icerikler.aspx");
        }
    }
}