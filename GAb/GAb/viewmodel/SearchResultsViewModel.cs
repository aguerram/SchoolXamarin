using GAb.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAb.viewmodel
{
	class SearchResultsViewModel:BaseViewModel
	{
		private List<Student> students { get; set; }
		public List<Student> Students { get { return students; } set { students = value; OnPropertyChanged(); } }
		public SearchResultsViewModel(List<Student> l)
		{
			students = l;
		}
	}
}
