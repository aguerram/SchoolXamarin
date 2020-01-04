using GAb.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GAb.viewmodel
{
	class StudentListViewModel: BaseViewModel
	{
		public ObservableCollection<StudentListItem> Students { get; set; }
		public List<Option> Options { get; set; }
		public List<Lesson> Lessons { get; set; }
		public StudentListViewModel()
		{

			Students = new ObservableCollection<StudentListItem>();
			Options = new List<Option>();
			Lessons = new List<Lesson>();

			Options.Add(new Option("G.INFO"));
			Options.Add(new Option("GTR +"));

			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
			Students.Add(new StudentListItem(new Student("mostafa", "agueram", "a@a.a", "0652323232", 1)));
		}
	}
	class StudentListItem : Student
	{
		public String fullName { set; get; }
		public bool check {set; get; }
		public StudentListItem(Student s):base(s.f_name,s.l_name,s.email,s.phone,s.optionID)
		{
			fullName = f_name + " " + l_name;
			check = false;
		}
	}
	
}
