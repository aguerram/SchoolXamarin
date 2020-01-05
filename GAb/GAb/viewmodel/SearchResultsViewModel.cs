using GAb.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.viewmodel
{
	class SearchResultsViewModel:BaseViewModel
	{
		private List<StudentListItemNew> students { get; set; }
		public List<StudentListItemNew> Students { get { return students; } set { students = value; OnPropertyChanged(); } }
		public SearchResultsViewModel(List<StudentAbsenceRelated> l)
		{
			students = new List<StudentListItemNew>();
			Students = new List<StudentListItemNew>();
			foreach (StudentAbsenceRelated el in l)
			{
				var tAbsence = 0;
				var tPresence = 0;
				foreach(StudentAbsence a in el.absenceList)
				{
					if (a.absent)
						tAbsence++;
					else
					{
						tPresence++;
					}
				}
				Students.Add(new StudentListItemNew(el.studen, tAbsence, tPresence));
			}
		}
	}
	class StudentListItemNew : Student
	{
		public String fullName { set; get; }
		public bool check { set; get; }

		public int totalPresence { set; get; }
		public int totalAbsence  { set; get; }
		public Student s { get; set; }
		public StudentListItemNew(Student s, int tAbsence, int tPresence) : base(s.f_name, s.l_name, s.email, s.phone, s.optionID)
		{
			this.s = s;
			totalPresence = tPresence;
			totalAbsence = tAbsence;
			fullName = f_name + " " + l_name + " ";
			check = false;
		}
	}
}
