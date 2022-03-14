using System.Collections.Generic;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public interface ITeacherData
    {
        Task<List<TeachersModel>> GetTeachers();
        Task InsertTeacher(TeachersModel t);
        //Task<bool> TeacherExists(TeachersModel t);

        Task<bool> VerifyTeacher(TeacherModel t);
        Task<TeacherModel> GetTeacher(TeacherModel t);
    }
}