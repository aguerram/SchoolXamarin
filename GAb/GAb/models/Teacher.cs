using System;
using SQLite;

namespace GAb.models
{
	class Teacher
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }

		public String username { set; get; }
		public String password { set; get; }

		public Teacher(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

		public Teacher()
		{
		}
	}
}
