using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3Business;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            DataTable dtLogin = userInfoBusiness.LoginCheck(txtEmail.Text, txtPasword.Text);
            if (dtLogin.Rows.Count > 0)
            {
                
                Application["Userdetails"] = dtLogin;
                Application["Email"] = dtLogin.Rows[0][2].ToString();
                Application["Firstname"] = dtLogin.Rows[0][0].ToString();
                Response.Redirect("Home.aspx");


            }
            else
            {
                lblResult.Text = "Email id or password wrong!";
            }
        }
    }
}
  