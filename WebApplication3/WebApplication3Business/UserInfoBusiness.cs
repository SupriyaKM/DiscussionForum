
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3Data;
using WebApplication3Entity;

namespace WebApplication3Business
{
   public class UserInfoBusiness
    {
        public string InsertUser(UserInfoModel UserInfoModel)
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            string msg = userObj.InsertUser(UserInfoModel);
            return msg;
        }
        public DataTable GetUserInfo()
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            DataTable dt = userObj.GetUserInfo();
            return dt;
        }
        public DataTable LoginCheck(string Email, string Pasword)
        {
            UserInfoDataConnection userObj = new UserInfoDataConnection();
            DataTable dt = userObj.LoginCheck(Email, Pasword);
            return dt;
        }

        public static DataTable GetuserInfo()
        {
            throw new NotImplementedException();
        }
    }
}
