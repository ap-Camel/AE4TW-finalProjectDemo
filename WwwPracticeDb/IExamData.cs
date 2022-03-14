using System.Collections.Generic;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public interface IExamData
    {
        Task DeleteExam(ExamModel e);
        Task<List<ExamModel>> GetExams();
        Task InsertExam(ExamModel e);
        Task ChangeStatus(ExamModel e);
        Task<List<ExamModel>> GetExams(int s);
    }
}