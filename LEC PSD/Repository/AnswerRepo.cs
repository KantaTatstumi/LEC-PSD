using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Factory;

namespace LEC_PSD.Repository
{
    public class AnswerRepo
    {
        Entities11 db = new Entities11();
        AnswerFactory Answer_Factory = new AnswerFactory();

        public void RegToDatabase(string answer)
        {
            Answer answerInput = Answer_Factory.InputAnswer(answer);
            db.Answers.Add(answerInput);
            db.SaveChanges();
        }

        public void UpdateAnswer()
        {
            db.SaveChanges();
        }

        public List<Answer> getAllAnswer()
        {
            List<Answer> answers = (from Answer in db.Answers select Answer).ToList();
            return answers;
        }
    }
}