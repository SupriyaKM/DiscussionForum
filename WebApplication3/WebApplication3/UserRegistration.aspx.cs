using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3Business;
using WebApplication3Entity;

namespace WebApplication3
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            UserInfoModel UserInfoModelObj = new UserInfoModel();
            UserInfoBusiness userInfoBusiness = new UserInfoBusiness();
            UserInfoModelObj.Firstname = txtFirstname.Text;
            UserInfoModelObj.Lastname = txtLastname.Text;
            UserInfoModelObj.Email = txtEmail.Text;
            UserInfoModelObj.Mobile = Convert.ToInt32(txtMobile.Text);
            UserInfoModelObj.Pasword = txtPasword.Text;

            string msg = userInfoBusiness.InsertUser(UserInfoModelObj);
            DataTable dtUserInfo = UserInfoBusiness.GetuserInfo();
            gvUserInfo.DataSource = dtUserInfo;
            gvUserInfo.DataBind();
        }
    }
}