using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WebApplication3Entity;


namespace WebApplication3Data
{
    public class UserInfoDataConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-MU68NAA;Initial Catalog=DiscussionForumPost;Integrated Security=True";
        public string InsertUser(UserInfoModel userInfoModel)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into UserInfo values('" + userInfoModel.Firstname + "','" + userInfoModel.Lastname + "','" + userInfoModel.Email + "'," + userInfoModel.Mobile + ",'" + userInfoModel.Pasword + "')", sqlConnectionObj);
            adp.Fill(dt);
            return "Registerd successfully";
        }
        public DataTable GetUserInfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from UserInfo", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }

        public DataTable LoginCheck(string Email, string Pasword)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select Firstname,Lastname,Email,Mobile from UserInfo where Email='" + Email + "' and Pasword='" + Pasword + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;
        }
    }
}
