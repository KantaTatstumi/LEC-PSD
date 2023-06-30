using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Factory;

namespace LEC_PSD.Repository
{
    public class QuestionRepo
    {
        Entities11 db = new Entities11();
        QuestionFactory Question_Factory = new QuestionFactory();

        public void RegQuestionToDatabase(string id, string course_id, string question)
        {
            Question QuestionInput = QuestionFactory.InputQuestion(id, course_id, question);
            db.Questions.Add(QuestionInput);
            db.SaveChanges();
        }

        public List<Question> getAllQuestion()
        {
            List<Question> questions = (from Question in db.Questions select Question).ToList();
            return questions;
        }
    }
}