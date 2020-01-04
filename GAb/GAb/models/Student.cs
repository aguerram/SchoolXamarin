using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GAb.models
{
	class Student
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }

		public String f_name { set; get; }
		public String l_name { set; get; }

		[Unique]
		public String email { set; get; }
		public String phone { set; get; }
		
		public int optionID { set; get; }
	}
}
