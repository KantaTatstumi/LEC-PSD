﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;
using LEC_PSD.Controller;


namespace LEC_PSD.Views.Soal_Exam
{
    public partial class SoalFisika : System.Web.UI.Page
    {
        QuestionHandler Question_Handler = new QuestionHandler();
        AnswerHandler Answer_Handler = new AnswerHandler();
        AnswerController Answer_Controller = new AnswerController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
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
            int id1 = Convert.ToInt32("110101");
            int id2 = Convert.ToInt32("11010101");
            Fisika_Soal1.Text = Question_Handler.GetQuestion(id1).Course_Question;
            Fisika_jwb_Option_1_1.Text = Answer_Handler.GetAnswer(id2).Option_1;
            Fisika_jwb_Option_1_2.Text = Answer_Handler.GetAnswer(id2).Option_2;
            Fisika_jwb_Option_1_3.Text = Answer_Handler.GetAnswer(id2).Option_3;

            int id3 = Convert.ToInt32("110102");
            int id4 = Convert.ToInt32("11010102");
            Fisika_Soal2.Text = Question_Handler.GetQuestion(id3).Course_Question;
            Fisika_jwb_Option_2_1.Text = Answer_Handler.GetAnswer(id4).Option_1;
            Fisika_jwb_Option_2_2.Text = Answer_Handler.GetAnswer(id4).Option_2;
            Fisika_jwb_Option_2_3.Text = Answer_Handler.GetAnswer(id4).Option_3;

            int id5 = Convert.ToInt32("110103");
            int id6 = Convert.ToInt32("11010103");
            Fisika_Soal3.Text = Question_Handler.GetQuestion(id5).Course_Question;
            Fisika_jwb_Option_3_1.Text = Answer_Handler.GetAnswer(id6).Option_1;
            Fisika_jwb_Option_3_2.Text = Answer_Handler.GetAnswer(id6).Option_2;
            Fisika_jwb_Option_3_3.Text = Answer_Handler.GetAnswer(id6).Option_3;

            int id7 = Convert.ToInt32("110104");
            int id8 = Convert.ToInt32("11010104");
            Fisika_Soal4.Text = Question_Handler.GetQuestion(id7).Course_Question;
            Fisika_jwb_Option_4_1.Text = Answer_Handler.GetAnswer(id8).Option_1;
            Fisika_jwb_Option_4_2.Text = Answer_Handler.GetAnswer(id8).Option_2;
            Fisika_jwb_Option_4_3.Text = Answer_Handler.GetAnswer(id8).Option_3;

            int id9 = Convert.ToInt32("110105");
            int id10 = Convert.ToInt32("11010105");
            Fisika_Soal5.Text = Question_Handler.GetQuestion(id9).Course_Question;
            Fisika_jwb_Option_5_1.Text = Answer_Handler.GetAnswer(id10).Option_1;
            Fisika_jwb_Option_5_2.Text = Answer_Handler.GetAnswer(id10).Option_2;
            Fisika_jwb_Option_5_3.Text = Answer_Handler.GetAnswer(id10).Option_3;
        }

        protected void Submit_Fisika_1_Click(object sender, EventArgs e)
        {
            if (Fisika_jwb_Option_1_1.Checked)
            {
                string id = "11010101";
                string answer = Fisika_jwb_Option_1_1.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_1_2.Checked)
            {
                string id = "11010101";
                string answer = Fisika_jwb_Option_1_2.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_1_3.Checked)
            {
                string id = "11010101";
                string answer = Fisika_jwb_Option_1_3.Text;
                AnswerController.answerValidation(id, answer);
            }
        }

        protected void Submit_Fisika_2_Click(object sender, EventArgs e)
        {
            if (Fisika_jwb_Option_2_1.Checked)
            {
                string id = "11010102";
                string answer = Fisika_jwb_Option_2_1.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_2_2.Checked)
            {
                string id = "11010102";
                string answer = Fisika_jwb_Option_2_2.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_2_3.Checked)
            {
                string id = "11010102";
                string answer = Fisika_jwb_Option_2_3.Text;
                AnswerController.answerValidation(id, answer);
            }
        }

        protected void Submit_Fisika_3_Click(object sender, EventArgs e)
        {
            if (Fisika_jwb_Option_3_1.Checked)
            {
                string id = "11010103";
                string answer = Fisika_jwb_Option_3_1.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_3_2.Checked)
            {
                string id = "11010103";
                string answer = Fisika_jwb_Option_3_2.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_3_3.Checked)
            {
                string id = "11010103";
                string answer = Fisika_jwb_Option_3_3.Text;
                AnswerController.answerValidation(id, answer);
            }
        }

        protected void Submit_Fisika_4_Click(object sender, EventArgs e)
        {
            if (Fisika_jwb_Option_4_1.Checked)
            {
                string id = "11010104";
                string answer = Fisika_jwb_Option_4_1.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_4_2.Checked)
            {
                string id = "11010104";
                string answer = Fisika_jwb_Option_4_2.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_4_3.Checked)
            {
                string id = "11010104";
                string answer = Fisika_jwb_Option_4_3.Text;
                AnswerController.answerValidation(id, answer);
            }
        }

        protected void Submit_Fisika_5_Click(object sender, EventArgs e)
        {
            if (Fisika_jwb_Option_5_1.Checked)
            {
                string id = "11010105";
                string answer = Fisika_jwb_Option_5_1.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_5_2.Checked)
            {
                string id = "11010105";
                string answer = Fisika_jwb_Option_5_2.Text;
                AnswerController.answerValidation(id, answer);
            }
            else if (Fisika_jwb_Option_5_3.Checked)
            {
                string id = "11010105";
                string answer = Fisika_jwb_Option_5_3.Text;
                AnswerController.answerValidation(id, answer);
            }
        }

        protected void Fisika_Finish_exam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Course/Fisika.aspx?id=" + Session["id"].ToString());
        }
    }
}