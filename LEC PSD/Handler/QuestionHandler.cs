using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Model;
using LEC_PSD.Repository;

namespace LEC_PSD.Handler
{
    public class QuestionHandler
    {
        QuestionRepo Question_Repo = new QuestionRepo();

        public Question GetQuestion(int id)
        {
            Question questionList = Question_Repo.getAllQuestion().Where(x => id == x.Question_Id).ToList().FirstOrDefault();
            return questionList;
        }
    }
}