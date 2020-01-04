using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.models
{
	class StudentAbsence
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
		public DateTime date { set; get; }
		public int studentID {set;get;}
		public int lessonID {set;get;}

		public bool absent { set; get; }

	}
}
