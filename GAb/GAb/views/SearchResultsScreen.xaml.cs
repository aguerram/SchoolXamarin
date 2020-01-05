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

		private SearchResultsViewModel sModel;
		private List<StudentAbsenceRelated> finalList;


		public SearchResultsScreen(List<StudentAbsenceRelated> finalList)
		{
			this.finalList = finalList;
			InitializeComponent();
			sModel = new SearchResultsViewModel(finalList);

			BindingContext = sModel;
		}
	}
}