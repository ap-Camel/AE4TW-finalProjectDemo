using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public class ExamData : IExamData
    {
        private readonly ISqlDataAccess _db;

        List<ExamModel> exams;
        ExamModel exam;
        public ExamData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<ExamModel>> GetExams()
        {
            string sql = "select * from exam";

            return await _db.LoadMany<ExamModel>(sql);
        }

        public async Task<List<ExamModel>> GetExams(int s)
        {
            string sql = $"select distinct e.examID, e.title, e.status, e.teacherID from exam as e join teacher as t on e.teacherID = t.teacherID join enrolled as en on t.teacherID = en.teacherID where en.studentID = {s}";

            return await _db.LoadMany<ExamModel>(sql);
        }

        public async Task InsertExam(ExamModel e)
        {
            string sql = $"insert into exam values ('{e.title}', '{e.status}', {e.teacherID})";

            await _db.insertData(sql);
        }

        public async Task DeleteExam(ExamModel e)
        {
            string sql = $"DELETE FROM exam WHERE examID = {e.examID}";

            await _db.insertData(sql);
        }

        public async Task ChangeStatus(ExamModel e)
        {
            string sql;
            if(e.status == "not_available")
            {
                sql = $"update exam set status = 'available' where examID = {e.examID}";
            } else
            {
                sql = $"update exam set status = 'not_available' where examID = {e.examID}";
            }

            await _db.insertData(sql);

        }
    }
}
