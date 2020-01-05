using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.models
{
	public class StudentAbsence
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
		public DateTime date { set; get; }
		public int studentID {set;get;}
		public int lessonID {set;get;}

		public bool absent { set; get; }

		public StudentAbsence(DateTime date, int studentID, int lessonID, bool absent)
		{
			this.date = date;
			this.studentID = studentID;
			this.lessonID = lessonID;
			this.absent = absent;
		}

		public StudentAbsence()
		{
		}
	}
}
