using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class Ayar : System.Web.UI.Page
    {
        public Models.Ayar a = new Models.Ayar();


        protected void Page_Load(object sender, EventArgs e)
        {
            KurumsalContext ctx = new KurumsalContext();
            a = ctx.Ayarlar.FirstOrDefault();

            var dosya = Request.Files["logo"];

            var kaydedilecekyer = "/Content/yuklenenler/";
            if (dosya != null)
                dosya.SaveAs(Server.MapPath(kaydedilecekyer) + dosya.FileName);

            if(IsPostBack)
            {
                //Kullanıcı verilerini GET ile ilettiyse
                ////string emailget = Request.QueryString["email"];
                ////string copyrightget = Request.QueryString["copyright"];

                //Kullanıcı verilerini post ile ilettiyse
                string emailpost = Request.Form["email"];
                string copyrightpost = Request.Form["copyright"];

                if(a == null)
                {
                    Models.Ayar yeniayar = new Models.Ayar();
                    yeniayar.Copyright = copyrightpost;
                    yeniayar.MailAdres = emailpost;
                    yeniayar.Logo = kaydedilecekyer + dosya.FileName;
                    ctx.Ayarlar.Add(yeniayar);
                    ctx.SaveChanges();
                }
                else
                {
                    if(dosya!=null & dosya.ContentLength>0)
                        a.Logo = kaydedilecekyer + dosya.FileName;

                    a.Copyright = copyrightpost;
                    a.MailAdres = emailpost;
                    ctx.Entry(a).State = System.Data.Entity.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }
    }
}