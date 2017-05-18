using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace password.UI
{
    public partial class SignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();

            var cookie = HttpContext.Current.Request.Cookies["passwordId"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddYears(-3);
                Response.Cookies.Add(cookie);
            }

            cookie = HttpContext.Current.Request.Cookies["domain1Id"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddYears(-3);
                Response.Cookies.Add(cookie);
            }

            childSites.DataSource = new List<Site>(){
                new Site {Url = "http://www.domain1.com" },
                new Site {Url = "http://www.domain2.com" },
            };
            childSites.DataBind();
        }
    }

    public class Site
    {
        public string Url { get; set; }
    }
}