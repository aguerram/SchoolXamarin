using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.dao
{
	class LessonDAO
	{
		readonly SQLiteAsyncConnection _database;

		public LessonDAO()
		{
			string dbPath = config.Config.DB_PATH;
			//instanciate SQLLite Connection
			_database = new SQLiteAsyncConnection(dbPath);
			//create table from the model
			_database.CreateTableAsync<models.Lesson>().Wait();
		}
		public Task<List<models.Lesson>> ListAsync()
		{
			return _database.Table<models.Lesson>().ToListAsync();
		}

		public Task<models.Lesson> GetByIdAsync(int id)
		{
			return _database.Table<models.Lesson>()
							.Where(i => i.ID == id)
							.FirstOrDefaultAsync();
		}


		public Task<int> SaveAsync(models.Lesson v)
		{
			if (v.ID != 0)
			{
				return _database.UpdateAsync(v);
			}
			else
			{
				return _database.InsertAsync(v);
			}
		}

		public Task<int> DeleteAsync(models.Lesson v)
		{
			return _database.DeleteAsync(v);
		}
	}
}
