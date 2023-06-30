using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Repository
{
    public class ClassRepo
    {
        Entities11 db = new Entities11();

        public List<string> getAllClassGrade()
        {
            List<string> classes = (from Class in db.Classes select Class.Class_Grade).ToList();
            return classes;
        }
        public List<string> getAllClassMajor()
        {
            List<string> classes = (from Class in db.Classes select Class.Class_Major).ToList();
            return classes;
        }
        public List<Class> getAllClass()
        {
            List<Class> classes = (from Class in db.Classes select Class).ToList();
            return classes;
        }
    }
}