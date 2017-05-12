using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace password.UI
{
    public partial class HasLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果登陆了
            if (Session["UserId"] != null && !string.IsNullOrEmpty(Session["UserId"].ToString()))
            {
                if (!string.IsNullOrEmpty(Request["returnUrl"]))
                    Response.Redirect(Request["returnUrl"] + "?&hasLogin=true&userId=" + Session["UserId"]);
                else
                    Response.Redirect("/UserInfo.aspx");
            }
            else
                Response.Redirect("/login.aspx?returnUrl=" + Request["returnUrl"]);
        }
    }
}