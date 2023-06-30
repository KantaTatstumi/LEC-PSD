using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Repository;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.Course
{
    public partial class English : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentHandler Student_Handler = new StudentHandler();
            LecturerHandler Lecturer_Handler = new LecturerHandler();

            if(IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Eng_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Eng_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }

                if (Student_Handler.GetStudentById(id).Role_Id == 2)
                {
                    Tambah_Soal_Eng.Visible = true; 
                }
            }

           
        }

        protected void Eng_Mock_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/MockExam/EnglishMockExam.aspx?id=" + Session["id"].ToString());
        }

        protected void Eng_Bab4_Click(object sender, EventArgs e)
        {

        }

        protected void Eng_Bank_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Bank_Soal/BankSoalEnglish.aspx?id=" + Session["id"].ToString());
        }

        protected void Tambah_Soal_Eng_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InputSoal/InputSoal.aspx?id=" + Session["id"].ToString());
        }
    }
}