using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;

namespace LEC_PSD.Factory
{
    public class AnswerFactory
    {
        public Answer InputAnswer(string answer)
        {
            Answer newAnswer = new Answer();

            newAnswer.Student_Answer = answer;

            return newAnswer;
        }
    }
}