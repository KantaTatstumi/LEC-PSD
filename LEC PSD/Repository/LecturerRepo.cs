using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Repository
{
    public class LecturerRepo
    {
        Entities11 db = new Entities11();
        public List<Lecturer> getAllLecturer()
        {
            List<Lecturer> lecturers = (from Lecturer in db.Lecturers select Lecturer).ToList();
            return lecturers;
        }
    }
}