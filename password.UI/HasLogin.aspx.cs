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
            var userId = Session["UserId"];
            string returnUrl = Request["returnUrl"];

            if (userId != null && !string.IsNullOrEmpty(userId.ToString()))
            {
                if (!string.IsNullOrEmpty(returnUrl))
                    Response.Redirect(returnUrl + "?hasLogin=true&userId=" + userId);
                else
                    Response.Redirect("/UserInfo.aspx");
            }
            else
                Response.Redirect("/login.aspx?returnUrl=" + returnUrl);
        }
    }
}