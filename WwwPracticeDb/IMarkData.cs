using System.Collections.Generic;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public interface IMarkData
    {
        Task<bool> AddMark(int m, int s, int e);
        Task<List<MarkModel>> GetMarks(int s);
    }
}