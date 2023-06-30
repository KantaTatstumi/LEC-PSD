using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Repository;

namespace LEC_PSD.Handler
{
    public class ClassHandler
    {
        ClassRepo class_Repo = new ClassRepo();

        public Class getClassGrade(string class_grade)
        {
            Class classlist = class_Repo.getAllClass().Where(x => string.Compare(class_grade, x.Class_Grade.ToString()) == 0).ToList().FirstOrDefault();
            return classlist;
        }
        public Class getClassMajor(string class_major)
        {
            Class classlist = class_Repo.getAllClass().Where(x => string.Compare(class_major, x.Class_Major.ToString()) == 0).ToList().FirstOrDefault();
            return classlist;
        }
        public Class getClass(int id)
        {
            Class classlist = class_Repo.getAllClass().Where(x => id == x.Class_Id).ToList().FirstOrDefault();
            return classlist;
        }
    }
}