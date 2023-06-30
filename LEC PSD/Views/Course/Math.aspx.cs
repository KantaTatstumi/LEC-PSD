using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.Course
{
    public partial class Math : System.Web.UI.Page
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
                    Math_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Math_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }

                if (Lecturer_Handler.GetLecturerById(id).Role_Id == 2)
                {
                    Tambah_Soal_Math.Visible = true;
                }
            }
        }

        protected void Math_Mock_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/MockExam/MathMockExam.aspx?id=" + Session["id"].ToString());
        }

        protected void Math_Bank_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Bank_Soal/BankSoalMath.aspx?id=" + Session["id"].ToString());
        }
    }
}