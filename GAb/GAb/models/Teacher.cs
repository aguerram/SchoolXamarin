using System;
using SQLite;

namespace GAb.models
{
	public class Teacher
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
        [Unique]
		public String username { set; get; }
		public String password { set; get; }
        public Teacher(string username)
        {
            this.username = username;
        }
        public Teacher(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

		public Teacher()
		{
		}

        public override string ToString()
        {
            return this.username;
        }
    }
}
