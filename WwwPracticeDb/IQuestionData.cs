using System.Collections.Generic;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public interface IQuestionData
    {
        Task DeleteQuestion(QuestionModel q);
        Task<List<QuestionModel>> GetQuestions();
        Task InsertQuestion(QuestionModel q);
        Task<bool> AddQuestion(QuestionModel q);
        Task<QuestionModel> GetLastQuestion();
        Task<List<QuestionModel>> GetQuestions(int t);
        Task<bool> AddExamQuestion(int e, int q);
        Task RemoveQuestion(int e, QuestionModel q);
        Task<List<QuestionModel>> GetExamQuestions(int t, int e);
        Task<List<QuestionModel>> GetExamingQuestions(int t, int e);
        Task<int> verify(List<ChoosenAnswersModel> c);
    }
}