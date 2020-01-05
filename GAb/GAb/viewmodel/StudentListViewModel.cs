using GAb.dao;
using GAb.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GAb.viewmodel
{
	class StudentListViewModel: BaseViewModel
	{
		OptionDAO optionDAO = new OptionDAO();
		StudentDAO studentDAO = new StudentDAO();
		LessonDAO lessonDAO = new LessonDAO();

		public ObservableCollection<StudentListItem> Students { get { return students; } set { students = value;OnPropertyChanged(); } }
		private ObservableCollection<StudentListItem> students { get; set; }
		private List<Option> options { get; set; }
		private ObservableCollection<Lesson> lessons { get; set; }


		public List<Option> Options { get { return options; } set { options = value; OnPropertyChanged(); } }
		public ObservableCollection<Lesson> Lessons { get { return lessons; } set { lessons = value; OnPropertyChanged(); } }

		private List<Student> StudentsDB { get; set; }
		private List<Lesson> LessonDB { get; set; }

		public StudentListViewModel()
		{

			Students = new ObservableCollection<StudentListItem>();
			students = new ObservableCollection<StudentListItem>();

			Options = new List<Option>();
			Lessons = new ObservableCollection<Lesson>();

			options = new List<Option>();
			lessons = new ObservableCollection<Lesson>();

			StudentsDB = new List<Student>();
			LessonDB = new List<Lesson>();

			init();
		}
		public async void init()
		{
			Options = await optionDAO.ListAsync();
			StudentsDB = await studentDAO.ListAsync();
			LessonDB = await lessonDAO.ListAsync();
			if (Options.Count == 0)
			{
				await optionDAO.SaveAsync(new models.Option("G.INFO"));
				await optionDAO.SaveAsync(new models.Option("GTR"));
				await optionDAO.SaveAsync(new models.Option("GIndus"));
				await optionDAO.SaveAsync(new models.Option("GPMC"));
				Options = await optionDAO.ListAsync();
			}
		}

		public void selectByOption(Option o)
		{
			Students.Clear();
			foreach (Student s in StudentsDB)
			{
				if (s.optionID != o.ID)
					continue;
				Students.Add(new StudentListItem(s));
			}

			Lessons.Clear();
			foreach(Lesson l in LessonDB)
			{
				
				if(l.optionID == o.ID && App.currentTeacher.ID == l.teacherID)
				
					Lessons.Add(l);
				}
			}
			
		}
	}
	class StudentListItem : Student
	{
		public String fullName { set; get; }
		public bool check {set; get; }

		public Student s { get; set; }
		public StudentListItem(Student s):base(s.f_name,s.l_name,s.email,s.phone,s.optionID)
		{
			this.s = s;
			fullName = f_name + " " + l_name;
			check = false;
		}
	}
	

