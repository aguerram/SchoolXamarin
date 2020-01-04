using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.dao
{
	class OptionDAO
	{
		readonly SQLiteAsyncConnection _database;
		public OptionDAO()
		{
			string dbPath = config.Config.DB_PATH;
			//instanciate SQLLite Connection
			_database = new SQLiteAsyncConnection(dbPath);
			//create table from the model
			_database.CreateTableAsync<models.Option>().Wait();

            //SaveAsync(new models.Option("G.INFO"));
            //SaveAsync(new models.Option("GTR"));
            //SaveAsync(new models.Option("GIndus"));
            //SaveAsync(new models.Option("GPMC"));
            //_database.ExecuteAsync("Delete from Option;");
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
