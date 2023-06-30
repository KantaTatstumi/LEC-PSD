using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LEC_PSD.Model;
using LEC_PSD.Repository;
using LEC_PSD.Handler;

namespace LEC_PSD.Views
{
    public partial class Login : System.Web.UI.Page
    {

        StudentHandler Student_Handler = new StudentHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["ActiveUser"];
            if (cookie != null)
            {
                Response.Redirect("~/Views/HomePage/Home.aspx?id=" + cookie["id"].ToString());
            }

        }

        protected void Log_In_Click(object sender, EventArgs e)
        {
            string email = Email_Login.Text.ToString();
            string password = Password_Login.Text.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Tolong isi username dan password')", true);
            } else
            {
                Boolean accountDoesExist = Student_Handler.AccountDoesExist(email, password);

                if (accountDoesExist)
                {
                    Response.Redirect("~/Views/Home.aspx?id=" + Student_Handler.GetStudentId(email, password));
                } else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('username atau password salah atau akun belum terdaftar')", true);
                }
            }

          

            
        }
    }
}