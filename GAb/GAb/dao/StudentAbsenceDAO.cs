using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.dao
{
	class StudentAbsenceDAO
	{
		readonly SQLiteAsyncConnection _database;
		public StudentAbsenceDAO()
		{
			string dbPath = config.Config.DB_PATH;
			//instanciate SQLLite Connection
			_database = new SQLiteAsyncConnection(dbPath);
			//create table from the model
			_database.CreateTableAsync<models.StudentAbsence>().Wait();
		}
		public Task<int> saveAsync(models.StudentAbsence sa)
		{
			return _database.InsertAsync(sa);
		}
		public Task<List<models.StudentAbsence>> getStudentAbsence(int student_id, int lesson_id)
		{
			return _database.Table<models.StudentAbsence>()
				.Where(el => el.studentID == student_id && el.lessonID == lesson_id)
				.ToListAsync();
		}

	}
}
