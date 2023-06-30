using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.MockExam
{
    public partial class MultimediaMockExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentHandler Student_Handler = new StudentHandler();
            if (IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Multimedia_Mock_Username.Text = Student_Handler.GetStudentById(id).Student_Name;
                    Multimedia_Guest_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Multimedia_Guest_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }
            }
        }

        protected void Multimedia_Exam_Start_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numrand = rand.Next();
            Multimedia_kode_exam.Text = numrand.ToString();

            string[] status = { "Finised", "Not Started" };
            int i = Array.IndexOf(status, Multimedia_Status_Exam);
            
            if (i >= 0 && i < 2)
            {
                Multimedia_Status_Exam.Text = status[i + 1];
            }
            else
            {
                Multimedia_Status_Exam.Text = status[0];
            }
            Response.Redirect("~/Views/Soal_Exam/SoalMultimedia.aspx?id=" + Session["id"].ToString());

        }
    }
}