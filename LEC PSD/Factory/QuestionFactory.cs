using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Factory
{
    public class QuestionFactory
    {
        public static Question InputQuestion(string id, string course_id, string question)
        {
            Question newQuestion = new Question();

            newQuestion.Question_Id = Convert.ToInt32(id);
            newQuestion.Course_Id = Convert.ToInt32(course_id);
            newQuestion.Course_Question = question;

            return newQuestion;
        }
    }
}