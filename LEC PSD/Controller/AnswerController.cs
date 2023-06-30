using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Repository;
using LEC_PSD.Factory;
using LEC_PSD.Handler;

namespace LEC_PSD.Controller
{
    public class AnswerController
    {
        public static string answerValidation(string id, string answer)
        {
            AnswerHandler Answer_Handler = new AnswerHandler();
            AnswerFactory Answer_Factory = new AnswerFactory();
            

            Boolean emptyAnswer1 = string.IsNullOrEmpty(answer);

            if(!emptyAnswer1)
            {
                Answer_Handler.updateAnswer(id, answer);
                return "Continue!!";
            } else
            {
                return "Alert : jawaban belum terisi!";
            }
        }
    }
}