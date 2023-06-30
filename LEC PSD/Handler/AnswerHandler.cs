using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Factory;
using LEC_PSD.Repository;

namespace LEC_PSD.Handler
{
    public class AnswerHandler
    { 
        AnswerRepo Answer_Repo = new AnswerRepo();

        public void updateAnswer(string id,string answer)
        {
            Answer upAnswer = Answer_Repo.getAllAnswer().Where(x => string.Compare(id, x.Answer_Id.ToString()) == 0).ToList().FirstOrDefault();
            upAnswer.Student_Answer = answer;

            Answer_Repo.UpdateAnswer();
        }
        public Answer GetAnswer(int id)
        {
            Answer answerList = Answer_Repo.getAllAnswer().Where(x => id == x.Answer_Id).ToList().FirstOrDefault();
            return answerList;
        }
    }
}