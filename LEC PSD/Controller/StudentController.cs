using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Repository;
using LEC_PSD.Factory;
using LEC_PSD.Handler;

namespace LEC_PSD.Controller
{
    public class StudentController
    {
        public static string AccountValidation(string username, string age, string email, string password, string grade, string major)
        {
            StudentRepo Student_Repo = new StudentRepo();
            StudentHandler Student_Handler = new StudentHandler();

            Boolean emptyUsername = string.IsNullOrEmpty(username);

            Boolean emptyAge = string.IsNullOrEmpty(age);

            Boolean emptyEmail = string.IsNullOrEmpty(email);
            int validEmail = EmailValidation(email, emptyEmail);

            Boolean emptypassword = string.IsNullOrEmpty(password);

            Boolean emptygrade = string.IsNullOrEmpty(grade);

            Boolean emptymajor = string.IsNullOrEmpty(major);


            if (validEmail == 1 && !emptyUsername && !emptyAge && !emptyEmail && !emptypassword && !emptygrade && !emptymajor)
            {
                if (!Student_Handler.AccountDoesExist(username, password))
                {
                    Student_Repo.RegToDatabase(username, age, email, password, grade, major);
                    return "APPROVED";
                }
                else
                {
                    return "alert('Akun dengan username dan password yang sama telah ada, mohon buat dengan nama dan password yang berbeda')";
                }
            }
            else
            {
                return AlertCollection(validEmail, emptyUsername, emptyAge, emptyEmail,emptypassword, emptygrade, emptymajor);
            }

        }

        public static int EmailValidation(string Email, Boolean emptyEmail)
        {
            int emailLength = Email.Length;
            if (!emptyEmail && Email[emailLength - 1] == 'm' && Email[emailLength - 2] == 'o' && Email[emailLength - 3] == 'c' && Email[emailLength - 4] == '.') return 1;
            else return 0;
        }

        public static string AlertCollection(int validEmail, Boolean emptyUsername, Boolean emptyAge, Boolean emptyEmail, Boolean emptypassword, Boolean emptygrade, Boolean emptymajor)
        {
            if(validEmail == 0)
            {
                return "alert('email masih salah')";
            }

            if (emptyUsername == true)
            {
                return "alert('Username Masih Kosong')";
            }

            if (emptyAge == true)
            {
                return "alert('Umur Masih Kosong')";
            }

            if (emptyEmail == true)
            {
                return "alert('Email Masih Kosong')";
            }

            if (emptypassword == true)
            {
                return "alert('Password Masih Kosong')";
            }

            if (emptygrade == true)
            {
                return "alert('Tingkat Kelas Masih Kosong')";
            }

            if (emptymajor == true)
            {
                return "alert('Jurusan Masih Kosong')";
            }

            return null;
        }

    }
}