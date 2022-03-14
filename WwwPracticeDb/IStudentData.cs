using System.Threading.Tasks;
using WwwPracticeDb.Models;
using System.Collections.Generic;

namespace WwwPracticeDb
{
    public interface IStudentData
    {
        Task<bool> VerifyStudent(StudentModel s);
        Task<List<StudentModel>> GetStudents();
        Task InsertStudent(StudentModel s);
        Task DeleteStudent(StudentModel s);
        Task<List<StudentModel>> GetStudents(int id);
        Task<List<StudentModel>> GetStudents(string s);
        Task RemoveStudent(int s, int t);
        Task<bool> AddStudent(int t, int s);
        Task<StudentModel> GetStudent(StudentModel s);
    }
}