using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace GAb.models
{
	class StudentLesson
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
		public int studentID { set; get; }
		public int lessonID { set; get; }
	}
}
