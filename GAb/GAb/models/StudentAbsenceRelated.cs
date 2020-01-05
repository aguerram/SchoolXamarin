using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.models
{
	public class StudentAbsenceRelated:Student
	{
		public List<StudentAbsence> absenceList;
		public Student studen;

		public StudentAbsenceRelated(List<StudentAbsence> absenceList, Student studen)
		{
			this.absenceList = absenceList;
			this.studen = studen;
		}
	}
}
