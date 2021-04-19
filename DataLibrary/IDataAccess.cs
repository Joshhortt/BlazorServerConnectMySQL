using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
	public interface IDataAccess
	{
		// List<T> LoadData<T, U>(string sql, U parameters, string connectionString);
		Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);

		//void SaveData<T>(string sql, T parameters, string connectionString);
		Task SaveData<T>(string sql, T parameters, string connectionString);
	}
}