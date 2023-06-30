using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Repository;
using LEC_PSD.Factory;
using LEC_PSD.Handler;
using LEC_PSD.Controller;

namespace LEC_PSD.Views
{
    public partial class SignUp : System.Web.UI.Page
    {
        StudentRepo StudentRepo = new StudentRepo();
        ClassRepo class_Repo = new ClassRepo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Grade_List.DataSource = class_Repo.getAllClassGrade();
                Grade_List.DataBind();
                Major_List.DataSource = class_Repo.getAllClassMajor();
                Major_List.DataBind();
            }
     
        }

        protected void Sign_Up_Click(object sender, EventArgs e)
        {
            string username = Username_Register.Text.ToString();
            string age = Age_Register.Text.ToString();
            string email = Email_Register.Text.ToString();
            string password = Password_Register.Text.ToString();
            string grade = Grade_List.SelectedValue.ToString();
            string major = Major_List.SelectedValue.ToString();

            if (string.Compare(StudentController.AccountValidation(username, age, email, password, grade, major), "APPROVED") == 0)
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