using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication3Entity;

namespace WebApplication3
{
    public partial class Post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             LoadTutorialData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            PostDataConnection PostObj = new PostDataConnection();
            PostModel PostModelObj = new PostModel();

            PostModelObj.Post_Id = Convert.ToInt32(txtPost_Id.Text);
            PostModelObj.Post_Title = txtPost_Title.Text;
            PostModelObj.Post_Subtitle = txtPost_Subtitle.Text;
            PostModelObj.Post_Content = txtPost_Content.Text;
            PostModelObj.Post_status = txtPost_status.Text;

            string msg = PostObj.InsertPost(PostModelObj);

            DataTable dtResult = PostObj.SelectPost();
            gvPostDetails.DataSource = dtResult;
            gvPostDetails.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            PostDBConnection tutorialDBConnectionObj = new PostDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.EditPostById(Convert.ToInt32(txtPost_Id.Text));
            txtPost_Title.Text = dtResult.Rows[0][1].ToString();
            txtPost_Subtitle.Text = dtResult.Rows[0][2].ToString();
            txtPost_Content.Text = dtResult.Rows[0][3].ToString();
            txtPost_status.Text = dtResult.Rows[0][4].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            PostDBConnection tutorialDBConnectionObj = new PostDBConnection();
            PostModel postModel = new PostModel();

            postModel.Post_Id = Convert.ToInt32(txtPost_Id.Text);
            postModel.Post_Title = txtPost_Title.Text;
            postModel.Post_Subtitle = txtPost_Subtitle.Text;
            postModel.Post_Content = txtPost_Content.Text;
            postModel.Post_status = txtPost_status.Text;

            string msg = tutorialDBConnectionObj.UpdateTutorial(postModel);
            lblResult.Text = msg;

            LoadTutorialData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            PostDBConnection tutorialDBConnectionObj = new PostDBConnection();
            string msg = tutorialDBConnectionObj.DeleteTutorialById(Convert.ToInt32(txtPost_Id.Text));
            lblResult.Text = msg;

            LoadTutorialData();
        }

        public void LoadTutorialData()
        {
            PostDBConnection tutorialDBConnectionObj = new PostDBConnection();
            DataTable dtResult = tutorialDBConnectionObj.SelectTutorial();
            gvTutorialDetails.DataSource = dtResult;
            gvTutorialDetails.DataBind();
        }
    }
}