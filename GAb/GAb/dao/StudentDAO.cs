using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace GAb.dao
{
    class StudentDAO
    {

        readonly SQLiteAsyncConnection _database;

        public StudentDAO()
        {
            string dbPath = config.Config.DB_PATH;
            //instanciate SQLLite Connection
            _database = new SQLiteAsyncConnection(dbPath);
            //create table from the model
            _database.CreateTableAsync<models.Student>().Wait();
        }
        public Task<List<models.Student>> ListAsync()
        {
            return _database.Table<models.Student>().ToListAsync();
        }

        public Task<models.Student> GetByIdAsync(int id)
        {
            return _database.Table<models.Student>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }
        public Task<List<models.Student>> GetByNameAsync(string name)
        {
			return _database.Table<models.Student>()
							.Where(i => i.f_name.ToLower().Equals(name) || i.l_name.ToLower().Equals(name))
							.ToListAsync();
        }


        public Task<int> SaveAsync(models.Student v)
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

        public Task<int> DeleteAsync(models.Student v)
        {
            return _database.DeleteAsync(v);
        }
        
    }
}

