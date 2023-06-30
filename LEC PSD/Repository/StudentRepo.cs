using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Factory;

namespace LEC_PSD.Repository
{
    public class StudentRepo
    {
        Entities11 db = new Entities11();

        public void RegToDatabase(string username,string age,string email,string password, string grade, string major)
        {
            Student student = StudentFactory.CreateUser(username, age, email, password, grade, major);
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpToDatabase()
        {
            db.SaveChanges();
        }

        public Student Login(string email, string password)
        {
            Student student = db.Students.Where(x => x.Student_Email == email && x.Student_Password == password).FirstOrDefault();
            return student;
        }

        public List<string> GetStudentGrade()
        {
            List<string> allStudentGrade = (from Student in db.Students select Student.Grade).ToList();
            return allStudentGrade;
        }

        public List<string> GetStudentMajor()
        {
            List<string> allStudentMajor = (from Student in db.Students select Student.Major).ToList();
            return allStudentMajor;
        }


        public List<Student> Students()
        {
            List<Student> allStudent = (from Student in db.Students select Student).ToList();
            return allStudent;
        }
    }
}