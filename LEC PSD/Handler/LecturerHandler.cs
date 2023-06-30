using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Repository;

namespace LEC_PSD.Handler
{
    public class LecturerHandler
    {
        LecturerRepo Lecturer_Repo = new LecturerRepo();
        public Lecturer GetLecturer(int id)
        {
            Lecturer lecturerList = Lecturer_Repo.getAllLecturer().Where(x => id == x.Lecturer_Id).ToList().FirstOrDefault();
            return lecturerList;
        }

        public Lecturer GetLecturerById(string Id)
        {
            Lecturer LecturerList = Lecturer_Repo.getAllLecturer().Where(x => string.Compare(Id, x.Lecturer_Id.ToString()) == 0).ToList().FirstOrDefault();
            return LecturerList;
        }

        public List<Lecturer> EmailInDatabase(string email)
        {
            List<Lecturer> emailList =Lecturer_Repo.getAllLecturer().Where(x => string.Compare(email, x.Lecturer_Email.ToString()) == 0).ToList();
            return emailList;
        }

        public Lecturer LecturerAccount(string email, string password)
        {
            List<Lecturer> lecturerList = EmailInDatabase(email);
            Lecturer acoountExist = lecturerList.Where(x => string.Compare(password, x.Lecturer_Password.ToString()) == 0).FirstOrDefault();
            return acoountExist;
        }

        public Lecturer GetLecturerData(string email, string password)
        {
            Lecturer accountExist = LecturerAccount(email, password);
            return accountExist;
        }

        public Boolean AccountDoesExist(string email, string password)
        {
            Lecturer accountDoesExist = GetLecturerData(email, password);

            if (accountDoesExist == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetLecturerId(string email, string password)
        {
            Lecturer accountDoesExist = LecturerAccount(email, password);
            return accountDoesExist.Lecturer_Id.ToString();
        }
    }
}