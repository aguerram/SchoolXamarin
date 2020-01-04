using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.dao
{
	class TeacherDAO
	{
		readonly SQLiteAsyncConnection _database;

		public TeacherDAO()
		{
			string dbPath = config.Config.DB_PATH;
            //instanciate SQLLite Connection
			_database = new SQLiteAsyncConnection(dbPath);
            //create table from the model
			_database.CreateTableAsync<models.Teacher>().Wait();
		}
		public Task<List<models.Teacher>> ListAsync()
		{
			return _database.Table<models.Teacher>().ToListAsync();
		}

		public Task<models.Teacher> GetByIdAsync(int id)
		{
			return _database.Table<models.Teacher>()
							.Where(i => i.ID == id)
							.FirstOrDefaultAsync();
		}
        public Task<models.Teacher> GetByUsernameAsync(string username)
        {
            return _database.Table<models.Teacher>()
                            .Where(i => i.username == username)
                            .FirstOrDefaultAsync();
        }


        public Task<int> SaveAsync(models.Teacher v)
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

		public Task<int> DeleteAsync(models.Teacher v)
		{
			return _database.DeleteAsync(v);
		}
		public Task<models.Teacher> LoginAsync(models.Teacher v)
		{
			return _database.Table<models.Teacher>()
				.Where
				(
				e => e.username.Equals(v.username) && e.password.Equals(v.password)
				).FirstOrDefaultAsync();
		}
	}
}
