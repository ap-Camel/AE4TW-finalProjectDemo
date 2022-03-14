using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public class TeacherData : ITeacherData
    {
        private readonly ISqlDataAccess _db;
        private TeachersModel teacher;
        private TeacherModel teacherModel;
        private TeacherModel secureTeacherModel;

        public TeacherData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TeachersModel>> GetTeachers()
        {
            string sql = "select * from Teachers";

            return _db.LoadData<TeachersModel, dynamic>(sql, new { });
        }

        public Task InsertTeacher(TeachersModel t)
        {
            string sql = @"insert into Teachers (PersonID, firstName, lastName)
                            values (@PersonID, @firstName, @lastName);";

            return _db.SaveData(sql, t);
        }

        //public async Task<bool> TeacherExists(TeachersModel t)
        //{
        //    string sql = $"select * from Teachers where PersonID = {t.PersonID} and LastName = '{t.lastName}' and FirstName = '{t.firstName}'";

        //    teacher = await _db.LoadDataSingle(sql);

        //    if (teacher.PersonID == t.PersonID && teacher.firstName == t.firstName && teacher.lastName == t.lastName)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public async Task<bool> VerifyTeacher(TeacherModel t)
        {
            string sql = $"select * from teacher where email = '{t.email}' and password = '{t.password}'";

            teacherModel = await _db.LoadSingle<TeacherModel>(sql);

            if(teacherModel == null)
            {
                return false;
            }
            else if(teacherModel.email == t.email && teacherModel.password == t.password)
            {
                teacherModel = null;

                return true;
            }

            teacherModel = null;
            return false;
        }

        public async Task<TeacherModel> GetTeacher(TeacherModel t)
        {
            string sql = $"select * from teacher where email = '{t.email}' and password = '{t.password}'";

            teacherModel = await _db.LoadSingle<TeacherModel>(sql);

            if (teacherModel == null)
            {
                return new TeacherModel();
            }
            else if (teacherModel.email == t.email && teacherModel.password == t.password)
            {
                secureTeacherModel = new TeacherModel();

                secureTeacherModel.teacherID = teacherModel.teacherID;
                secureTeacherModel.firstName = teacherModel.firstName;
                secureTeacherModel.lastName = teacherModel.lastName;
                secureTeacherModel.email = teacherModel.email;

                teacherModel = null;

                return secureTeacherModel;
            }

            return new TeacherModel();
        }
    }
}
