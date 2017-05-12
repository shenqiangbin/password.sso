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

            HttpHelper.SendGet("http://www.domain1.com/SignOut.aspx");
            //HttpHelper.SendGet("http://www.domain2.com/SignOut.aspx");
            //HttpHelper.SendGet("http://www.domain3.com/SignOut.aspx");
        }
    }
}