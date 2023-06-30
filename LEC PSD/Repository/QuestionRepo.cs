using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Repository
{
    public class QuestionRepo
    {
        Entities11 db = new Entities11();

        public List<Question> getAllQuestion()
        {
            List<Question> questions = (from Question in db.Questions select Question).ToList();
            return questions;
        }
    }
}