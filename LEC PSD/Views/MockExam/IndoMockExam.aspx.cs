﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Handler;

namespace LEC_PSD.Views.MockExam
{
    public partial class IndoMockExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentHandler Student_Handler = new StudentHandler();
            if (IsPostBack == false)
            {
                string id = Request["id"];
                if (id != null)
                {
                    Indo_Mock_Username.Text = Student_Handler.GetStudentById(id).Student_Name;
                    Indo_Guest_Kelas.Text = Student_Handler.GetStudentById(id).Grade;
                    Indo_Guest_Major.Text = Student_Handler.GetStudentById(id).Major;
                    Session["id"] = id;
                }
                else
                {
                    Response.Redirect("~/Views/Sign/Login.aspx");
                }
            }
        }

        protected void Indo_Exam_Start_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numrand = rand.Next();
            Indo_kode_exam.Text = numrand.ToString();

            string[] status = { "Finised", "Not Started" };
            int i = Array.IndexOf(status, Indo_Status_Exam);
            if (i >= 0 && i < 2)
            {
                Indo_Status_Exam.Text = status[i + 1];
            }
            else
            {
                Indo_Status_Exam.Text = status[0];
            }

            Response.Redirect("~/Views/Soal_Exam/SoalIndonesia.aspx?id=" + Session["id"].ToString());
        }
    }
}