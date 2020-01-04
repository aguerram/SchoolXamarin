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
            _database.CreateTableAsync<models.Option>().Wait();
        }
        public Task<List<models.Option>> ListAsync()
        {
            return _database.Table<models.Option>().ToListAsync();
        }

        public Task<models.Option> GetByIdAsync(int id)
        {
            return _database.Table<models.Option>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }
        public Task<models.Option> GetByUsernameAsync(string title)
        {
            return _database.Table<models.Option>()
                            .Where(i => i.title == title)
                            .FirstOrDefaultAsync();
        }


        public Task<int> SaveAsync(models.Option v)
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

        public Task<int> DeleteAsync(models.Option v)
        {
            return _database.DeleteAsync(v);
        }
        
    }
}

