using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public class StudentData : IStudentData
    {

        private readonly ISqlDataAccess _db;

        List<StudentModel> students;
        StudentModel student;
        public StudentData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<bool> VerifyStudent(StudentModel s)
        {
            string sql = $"select * from student where email = '{s.email}' and password = '{s.password}'";

            student = await _db.LoadSingle<StudentModel>(sql);

            if (student == null)
            {
                return false;
            }
            else if (student.email == s.email && student.password == s.password)
            {
                student = null;
                return true;
            }

            student = null;
            return false;
        }

        public async Task<List<StudentModel>> GetStudents()
        {
            string sql = $"select * from student";

            return await _db.LoadMany<StudentModel>(sql);
        }

        public async Task<List<StudentModel>> GetStudents(int id)
        {
            string sql = $"select s.StudentID, s.firstname, s.lastname, s.email from student as s join enrolled as e on s.studentID = e.studentID where e.teacherID = {id}";

            return await _db.LoadMany<StudentModel>(sql);
        }

        public async Task<StudentModel> GetStudent(StudentModel s)
        {
            string sql = $"select * from student where email = '{s.email}' and password = '{s.password}'";

            return await _db.LoadSingle<StudentModel>(sql);
        }

        public async Task<List<StudentModel>> GetStudents(string s)
        {
            string sql = $"select * from student where firstName = {s}";

            return await _db.LoadMany<StudentModel>(sql);
        }

        public async Task InsertStudent(StudentModel s)
        {
            string sql = $"insert into student values ('{s.firstName}', '{s.lastName}', '{s.password}', '{s.email}')";

            await _db.insertData(sql);
        }

        public async Task<bool> AddStudent(int t, int s)
        {
            string sql = $"insert into enrolled values ({t}, {s})";

            return await _db.insertData(sql);
        }

        public async Task DeleteStudent(StudentModel s)
        {
            string sql = $"DELETE FROM student WHERE studentID = {s.studentID}";

            await _db.insertData(sql);
        }

        public async Task RemoveStudent(int s, int t)
        {
            string sql = $"delete from enrolled where studentID = {s} and teacherID = {t}";

            await _db.insertData(sql);
        }
    }
}
