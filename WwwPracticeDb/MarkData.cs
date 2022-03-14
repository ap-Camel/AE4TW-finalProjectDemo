using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public class MarkData : IMarkData
    {
        private readonly ISqlDataAccess _db;

        List<ExamModel> exams;
        ExamModel exam;
        public MarkData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<MarkModel>> GetMarks(int s)
        {
            string sql = $"select * from mark where studentID = {s}";

            return await _db.LoadMany<MarkModel>(sql);
        }

        public async Task<bool> AddMark(int m, int s, int e)
        {
            string sql = $"insert into mark values ({m}, {s}, {e})";

            return await _db.insertData(sql);
        }
    }
}
