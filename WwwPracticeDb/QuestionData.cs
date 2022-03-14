using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public class QuestionData : IQuestionData
    {
        private readonly ISqlDataAccess _db;

        List<QuestionModel> questions;
        QuestionModel question;
        public QuestionData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<QuestionModel>> GetQuestions()
        {
            string sql = "select * from question";

            return await _db.LoadMany<QuestionModel>(sql);
        }

        public async Task<List<QuestionModel>> GetQuestions(int t)
        {
            string sql = $"select q.questionID, q.question, q.Canswer, q.Ranswer01, q.Ranswer02, q.Ranswer03, q.teacherID  from question as q " +
                $"left join exam_question as eq on q.questionID = eq.questionID left join exam as e on eq.examID = e.examID " +
                $"where e.teacherID = {t} or q.teacherID = {t}";

            return await _db.LoadMany<QuestionModel>(sql);
        }

        public async Task<List<QuestionModel>> GetExamQuestions(int t, int e)
        {
            string sql = $"select q.questionID, q.question, q.Canswer, q.Ranswer01, q.Ranswer02, q.Ranswer03, q.teacherID  from question as q " +
                $"left join exam_question as eq on q.questionID = eq.questionID left join exam as e on eq.examID = e.examID " +
                $"where e.teacherID = {t} or q.teacherID = {t} and eq.examID = {e}";

            return await _db.LoadMany<QuestionModel>(sql);
        }

        public async Task<List<QuestionModel>> GetExamingQuestions(int t, int e)
        {
            string sql = $"select q.questionID, q.question, q.Canswer, q.Ranswer01, q.Ranswer02, q.Ranswer03, q.teacherID  from question as q " +
                $"left join exam_question as eq on q.questionID = eq.questionID left join exam as e on eq.examID = e.examID " +
                $"where e.teacherID = {t} or q.teacherID = {t} and eq.examID = {e}";

            questions = await _db.LoadMany<QuestionModel>(sql);

            bool exists = false;
            int[] duplicates = new int[10];
            List<QuestionModel> returnList = new List<QuestionModel>();
            int count = 0;

            Random rand = new Random();
            int random;

            for(int i = 0; i < 10; i++)
            {
                while(count < 100)
                {
                    exists = false;
                    random = rand.Next(questions.Count);
                    for(int j = 0; j < 10; j++)
                    {
                        if(duplicates[j] == random)
                        {
                            exists = true;
                        }
                    }
                    if (!exists)
                    {
                        duplicates[i] = random;
                        returnList.Add(questions[random]);
                        break;
                    }
                    count++;
                }
            }

            return returnList;

            //while(duplicates.Length < 10)
            //{
            //    random = rand.Next(questions.Count);
            //    for(int i = 0; i < duplicates.Length; i++)
            //    {
            //        if(duplicates[i] == random)
            //        {
            //            break;
            //        } else
            //        {
            //            returnList.Add(questions[random]);
            //        }
            //    }
            //}

        }

        public async Task<int> verify(List<ChoosenAnswersModel> c)
        {
            string sql;
            int mark = 0;

            for(int i = 0; i < 10; i++)
            {
                sql = $"select Canswer from question where questionID = {c[i].questionID}";

                question = await _db.LoadSingle<QuestionModel>(sql);

                if (question.Canswer == c[i].answer) mark += 10;
            }
            
            return mark;
        }

        public async Task<QuestionModel> GetLastQuestion()
        {
            string sql = "select* from question where questionID = (select max(questionID) from question)";

            return await _db.LoadSingle<QuestionModel>(sql);
        }

        public async Task InsertQuestion(QuestionModel q)
        {
            string sql = $"insert into question values ('{q.question}', '{q.Canswer}', '{q.Ranswer01}', '{q.Ranswer02}', '{q.Ranswer03}', {q.teacherID})";

            await _db.insertData(sql);
        }

        public async Task DeleteQuestion(QuestionModel q)
        {
            string sql = $"delete from exam_question where questionID = {q.questionID}";

            await _db.insertData(sql);

            sql = $"DELETE FROM question WHERE questionID = {q.questionID}";

            await _db.insertData(sql);
        }

        public async Task RemoveQuestion(int e, QuestionModel q)
        {
            string sql = $"delete from exam_question where questionID = {q.questionID} and examID = {e}";

            await _db.insertData(sql);
        }

        public async Task<bool> AddExamQuestion(int e, int q)
        {
            string sql;
            if(e == 0)
            {
                sql = $"insert into exam_question values (null, {q})";
            } else
            {
                sql = $"insert into exam_question values ({e}, {q})";
            }

            return await _db.insertData(sql);
        }

        public async Task<bool> AddQuestion(QuestionModel q)
        {
            string sql = $"insert into question values ('{q.question}', '{q.Canswer}', '{q.Ranswer01}', '{q.Ranswer02}', '{q.Ranswer03}', {q.teacherID})";

            return await _db.insertData(sql);
        }
    }
}
