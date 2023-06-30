using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.Course
{
    public partial class Multimedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentHandler Student_Handler = new StudentHandler();
            LecturerHandler Lecturer_Handler = new LecturerHandler();
            if (IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Multimedia_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Multimedia_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }

                if (Lecturer_Handler.GetLecturerById(id).Role_Id == 2)
                {
                    Tambah_Soal_Multimedia.Visible = true;
                }
            }
        }

        protected void Multimedia_Mock_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/MockExam/MultimediaMockExam.aspx/id=" + Session["id"].ToString());
        }

        protected void Multimedia_Bank_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Bank_Soal/BankSoalMultimedia.aspx?id=" + Session["id"].ToString());
        }
    }
}