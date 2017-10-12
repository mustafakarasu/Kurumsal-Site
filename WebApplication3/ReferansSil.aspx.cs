using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class ReferansSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelenid = Request.QueryString["ID"];

            KurumsalContext ctx = new KurumsalContext();
            Referans r = ctx.Referanslar.Find(Convert.ToInt32(gelenid));
            ctx.Referanslar.Remove(r);
            ctx.SaveChanges();

            Response.Redirect("/Referanslar.aspx");

        }
    }
}