using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Controller;

namespace LEC_PSD.Views.InputSoal
{
    public partial class InputSoal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }
            }
        }

        protected void Execute_1_Click(object sender, EventArgs e)
        {
            string question_id = Question_Id.Text.ToString();
            string course_id = Course_Id.Text.ToString();
            string question = Question.Text.ToString();

            if (string.Compare(QuestionController.QuestionValidation(question_id,course_id,question), "Approved") == 0)
            {
                Response.Redirect("~/Views/Sign/Login.aspx");
            }
            else
            {
                printAlert("alert('Tolong cek kembali form register anda, masih terdapat kesalahan atau bagian yang mungkin belum terisi. Terima Kasih')");
            }
        }

        protected void Execute_2_Click(object sender, EventArgs e)
        {
            string answer_id = Answer_Id.Text.ToString();
            string question_id = Answer_Qst_Id.Text.ToString();
            string answer = Answer.Text.ToString();
            string choice1 = Choice1.Text.ToString();
            string choice2 = Choice2.Text.ToString();
            string choice3 = Choice3.Text.ToString();

            if (string.Compare(AnswerController.PreAnswerValidation(answer_id,question_id,answer,choice1,choice2,choice3), "Approved") == 0)
            {
                Response.Redirect("~/Views/Sign/Login.aspx");
            }
            else
            {
                printAlert("alert('Tolong cek kembali form register anda, masih terdapat kesalahan atau bagian yang mungkin belum terisi. Terima Kasih')");
            }
        }

        public void printAlert(string msg)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", msg, true);
        }
    }
}