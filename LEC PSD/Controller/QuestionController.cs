using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LEC_PSD.Repository;
using LEC_PSD.Factory;
using LEC_PSD.Handler;

namespace LEC_PSD.Controller
{
    public class QuestionController
    {
        public static string QuestionValidation(string id, string course_id, string question)
        {
            QuestionRepo Question_Repo = new QuestionRepo();
            QuestionHandler Question_Handler = new QuestionHandler();

            Boolean emptyId = string.IsNullOrEmpty(id);

            Boolean emptyCourseId = string.IsNullOrEmpty(course_id);

            Boolean emptyQuestion = string.IsNullOrEmpty(question);

            if(!emptyId && !emptyCourseId && !emptyQuestion)
            {
                Question_Repo.RegQuestionToDatabase(id, course_id, question);
                return "Approved";
            }
            else
            {
                return AllertCollection(emptyId, emptyCourseId, emptyQuestion);
            }

      
        }

        public static string AllertCollection(Boolean emptyId, Boolean emptyCourseId, Boolean emptyQuestion)
        {
            if(emptyId == true)
            {
                return "Id Belum Terisi";
            }

            if (emptyCourseId == true)
            {
                return "Course Id Belum Terisi";
            }

            if (emptyQuestion == true)
            {
                return "Pertanyaan Belum Terisi";
            }

            return null;
        }

            
    }
}