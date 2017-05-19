using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace password.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null && !string.IsNullOrEmpty(Session["UserId"].ToString()))
                Response.Redirect("/UserInfo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string tokenVal = Guid.NewGuid().ToString();

            //var cookie = new HttpCookie("token", tokenVal);
            //cookie.Domain = "www.password.com";
            //Response.Cookies.Add(cookie);

            //var userId = 100; //假如获取到的用户标识是100

            //TokenMgr.Add(new TokenItem { Token = tokenVal, Data = userId });

            if (true)
            {
                Session["UserId"] = 100;
            }

            if (!string.IsNullOrEmpty(Request["returnUrl"]))
                Response.Redirect(Request["returnUrl"] + "?&hasLogin=true&userId=" + Session["UserId"]);
            else
                Response.Redirect("/UserInfo.aspx");

        }
    }
}