using GAb.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.viewmodel
{
	class SearchResultsViewModel:BaseViewModel
	{
		private List<StudentListItem> students { get; set; }
		public List<StudentListItem> Students { get { return students; } set { students = value; OnPropertyChanged(); } }
		public SearchResultsViewModel(List<StudentAbsenceRelated> l)
		{
			students = new List<StudentListItem>();
			Students = new List<StudentListItem>();
			foreach (StudentAbsenceRelated el in l)
			{
				Students.Add(new StudentListItem(el.studen));
			}
		}
	}
	class StudentListItem : Student
	{
		public String fullName { set; get; }
		public bool check { set; get; }

		public int totalPresence = 0;
		public int totalAbsence = 0;
		public Student s { get; set; }
		public StudentListItem(Student s) : base(s.f_name, s.l_name, s.email, s.phone, s.optionID)
		{
			this.s = s;
			fullName = f_name + " " + l_name;
			check = false;
		}
	}
}
