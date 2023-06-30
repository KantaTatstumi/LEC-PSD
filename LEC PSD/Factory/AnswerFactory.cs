using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Factory
{
    public class AnswerFactory
    {
        public Answer InputAnswer(string id, string qst_id,string answer,string choice1, string choice2, string choice3)
        {
            Answer newAnswer = new Answer();

            newAnswer.Answer_Id = Convert.ToInt32(id);
            newAnswer.Question_Id = Convert.ToInt32(qst_id);
            newAnswer.Student_Answer = answer;
            newAnswer.Option_1 = choice1;
            newAnswer.Option_2 = choice2;
            newAnswer.Option_3 = choice3;

            return newAnswer;
        }
    }
}