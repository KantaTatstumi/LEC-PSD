using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Factory
{
    public class StudentFactory
    {
        public static Student CreateUser(string username, string age, string email, string password, string grade, string major)
        {
            Student newAccount = new Student();

            newAccount.Student_Name = username;
            newAccount.Student_Age = age;
            newAccount.Student_Email = email;
            newAccount.Student_Password = password;
            newAccount.Role_Id = 1;
            newAccount.Grade = grade;
            newAccount.Major = major;

            return newAccount;
        }
    }
}