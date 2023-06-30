using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Factory;
using LEC_PSD.Repository;
using LEC_PSD.Handler;

namespace LEC_PSD.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentRepo Student_Repo = new StudentRepo();
            StudentHandler Student_Handler = new StudentHandler();
            if(IsPostBack == false)
            {
                string id = Request["id"];
                
                if(id != null)
                {
                    Label_username.Text = Student_Handler.GetStudentById(id).Student_Name;
                    Guest_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Guest_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                } else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }

                if(Guest_Major.Text.ToString() == "IPA")
                {
                    Multimedia.Visible = false;
                    
                    
                } else if (Guest_Major.Text.ToString() == "IPS")
                {
                    Phsyics.Visible = false;
                } else
                {
                    Multimedia.Visible = false;
                    Phsyics.Visible = false;
                }
            }

        }

        protected void Search_Button2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Indo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/Indonesia.aspx?id=" + Session["id"].ToString());
        }

        protected void English_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/English.aspx?id=" + Session["id"].ToString());
        }

        protected void Mandarin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/Mandarin.aspx?id=" + Session["id"].ToString());
        }

        protected void Math_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/Math.aspx?id=" + Session["id"].ToString());
        }

        protected void Multimedia_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/Multimedia.aspx?id=" + Session["id"].ToString());
        }

        protected void Phsyics_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/Course/Fisika.aspx?id=" + Session["id"].ToString());
        }

        protected void Recommend1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=5IYMtCkG3Ss&pp=ygUUdXRiayBtYXRlbWF0aWthIDIwMjM%3D");
        }

        protected void Recommend2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=q6PgFN5Wupc&pp=ygUNdXRiayBUUEEgMjAyMw%3D%3D");
        }

        protected void Recommend3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=CXIqxUWo3Gw&pp=ygUNdXRiayBUUEEgMjAyMw%3D%3D");
        }

        protected void Recommend4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=8HDfo96ZP6s&pp=ygUNdXRiayBUUEEgMjAyMw%3D%3D");
        }

        protected void Recommend5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=cp1y62gaMSU&pp=ygUNdXRiayBUUEEgMjAyMw%3D%3D");
        }

        protected void Recommend6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.youtube.com/watch?v=MaGjOqFc5Rg&pp=ygUNdXRiayBUUEEgMjAyMw%3D%3D");
        }
    }
}