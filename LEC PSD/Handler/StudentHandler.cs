using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Repository;

namespace LEC_PSD.Handler
{
    public class StudentHandler
    {
        StudentRepo Student_Repo = new StudentRepo();

        public void UpdateAccount(string id, string username, string age, string email, string password, string grade, string major, int class_id)
        {
            Student UpAccount = Student_Repo.Students().Where(x => string.Compare(id, x.Student_Id.ToString()) == 0).ToList().FirstOrDefault();
            UpAccount.Student_Name = username;
            UpAccount.Student_Age = age;
            UpAccount.Student_Email = email;
            UpAccount.Student_Password = password;
            UpAccount.Grade = grade;
            UpAccount.Major = major;
            

            Student_Repo.UpToDatabase();
        }

        public Student GetAnswer(int id)
        {
            Student Student_List = Student_Repo.Students().Where(x => id == x.Student_Id).ToList().FirstOrDefault();
            return Student_List;
        }

        public List<Student> usernameInDatabase(string username)
        {
            List<Student> usernameList = Student_Repo.Students().Where(x => string.Compare(username, x.Student_Name.ToString()) == 0).ToList();
            return usernameList;
        }

        public List<Student> EmailInDatabase(string email)
        {
            List<Student> emailList = Student_Repo.Students().Where(x => string.Compare(email, x.Student_Email.ToString()) == 0).ToList();
            return emailList;
        }

        public Student StudentAccount(string email, string password)
        {
            List<Student> studentList = EmailInDatabase(email);
            Student acoountExist = studentList.Where(x => string.Compare(password, x.Student_Password.ToString()) == 0).FirstOrDefault();
            return acoountExist;
        }

        public Student GetStudent(string email, string password)
        {
            Student accountExist = StudentAccount(email, password);
            return accountExist;
        }

        public Student GetStudentById(string Id)
        {
            Student IdList = Student_Repo.Students().Where(x => string.Compare(Id, x.Student_Id.ToString()) == 0).ToList().FirstOrDefault();
            return IdList;
        }

        public Boolean AccountDoesExist(string email, string password)
        {
            Student accountDoesExist = GetStudent(email, password);

            if(accountDoesExist == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public string GetStudentId(string email, string password)
        {
            Student accountDoesExist = StudentAccount(email, password);
            return accountDoesExist.Student_Id.ToString();
        }
    }
}