using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAb.models;
using GAb.viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GAb.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchResultsScreen : ContentPage
	{
		private List<Student> studentsList { get; set; }
		public List<Student> StudentsList { get { return studentsList; } set { studentsList = value; } }

		private SearchResultsViewModel sModel;
		public SearchResultsScreen(List<Student> list)
		{
			InitializeComponent();
			StudentsList = list;
			sModel = new SearchResultsViewModel(list);

			BindingContext = sModel;
		}
	}
}