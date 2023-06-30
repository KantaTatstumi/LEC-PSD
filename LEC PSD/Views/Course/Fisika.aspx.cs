using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.Course
{
    public partial class Fisika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentHandler Student_Handler = new StudentHandler();
            if (IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Fisika_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Fisika_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }
            }
        }

        protected void Fisika_Mock_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/MockExam/FisikaMockExam.aspx?id=" + Session["id"].ToString());
        }

        protected void Fisika_Bank_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Bank_Soal/BankSoalFisika.aspx?id=" + Session["id"].ToString());
        }
    }
}