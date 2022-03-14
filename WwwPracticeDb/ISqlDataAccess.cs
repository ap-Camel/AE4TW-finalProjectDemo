using System.Collections.Generic;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwPracticeDb
{
    public interface ISqlDataAccess
    {
        string connectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        //Task<List<TeachersModel>> LoadData3(string sql);
        Task SaveData<T>(string sql, T parameters);
        //Task<TeachersModel> LoadDataSingle(string sql);

        Task<T> LoadSingle<T>(string sql);
        Task<List<T>> LoadMany<T>(string sql);
        Task<bool> insertData(string sql);
    }

}