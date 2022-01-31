using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3Entity;

namespace WebApplication3Data
{
   public class PostDataConnection
    {
        string sqlConnectionStr = "Data Source=DESKTOP-MU68NAA ;Initial Catalog=DiscussionForumPost;Integrated Security=True";
        public string InsertTutorial(PostModel PostObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("insert into Post values(" + PostObj.Post_Id + ",'" + PostObj.Post_Title + "','" + PostObj.Post_Subtitle + "','" + PostObj.Post_Content + "','" + PostObj.Post_status + "')", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Post details saved successfully";
        }
        public string UpdatePost(PostModel PostObj)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("update Post set Post Title='" + PostObj.Post_Title + "' , Post Subtitle='" + PostObj.Post_Subtitle + "' , Post Content=" + PostObj.Post_Content +"',Post Status="+ PostObj.Post_status + " where Post Id=" + PostObj.Post_Id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            // #region disconnected approach
            //SqlDataAdapter adp = new SqlDataAdapter("update Tutorial set tutorialname='" + tutorialModelObj.TutorialName + "' , tutorialdesc='" + tutorialModelObj.TutorialDesc + "' , published=" + tutorialModelObj.Published + " where tutorialid=" + tutorialModelObj.TutorialId + "", sqlConnectionObj);
            // adp.Fill(dt);
            // #endregion
            return "Post id " + PostObj.Post_Id + " details updated successfully";
        }
        public string DeletePostById(int Post_Id)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("delete from Post where PostId='" + Post_Id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            return "Tutorial id" + Post_Id + "details deleted successfully";
        }
        public DataTable SelectPost()
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Post", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public DataTable EditPostById(int Post_Id)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("select * from Post where PostId=" + Post_Id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
    }
}

