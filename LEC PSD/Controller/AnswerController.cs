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
        public static string PreAnswerValidation(string id, string qst_id, string answer, string choice1, string choice2, string choice3)
        {
            AnswerHandler Answer_Handler = new AnswerHandler();
            AnswerRepo Answer_Repo = new AnswerRepo();

            Boolean emptyId = string.IsNullOrEmpty(id);

            Boolean emptyQstId = string.IsNullOrEmpty(qst_id);

            Boolean emptyAnswer = string.IsNullOrEmpty(answer);

            Boolean emptyChoice1 = string.IsNullOrEmpty(choice1);

            Boolean emptyChoice2 = string.IsNullOrEmpty(choice2);

            Boolean emptyChoice3 = string.IsNullOrEmpty(choice3);

            if(!emptyId && !emptyQstId && !emptyAnswer && !emptyChoice1 && !emptyChoice2 && !emptyChoice3)
            {
                Answer_Repo.RegAnswerToDatabase(id, qst_id, answer, choice1, choice2, choice3);
                return "Approved";
            } else
            {
                return AllertCollection(emptyId, emptyQstId, emptyAnswer, emptyChoice1, emptyChoice2, emptyChoice3);
            }
        }

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

        public static string AllertCollection(Boolean emptyId, Boolean emptyQstId, Boolean emptyAnswer, Boolean emptyChoice1, Boolean emptyChoice2, Boolean emptyChoice3)
        {
            if (emptyId == true)
            {
                return "Id Belum Terisi";
            }

            if (emptyQstId == true)
            {
                return "Question Id Belum Terisi";
            }

            if (emptyAnswer == true)
            {
                return "Jawaban Belum Terisi";
            }

            if(emptyChoice1 == true)
            {
                return "Pilihan Pertama Belum Terisi";
            }

            if (emptyChoice2 == true)
            {
                return "Pilihan Kedua Belum Terisi";
            }

            if (emptyChoice3 == true)
            {
                return "Pilihan Ketiga Belum Terisi";
            }

            return null;
        }
    }
}