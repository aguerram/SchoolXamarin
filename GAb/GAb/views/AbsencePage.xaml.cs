using GAb.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GAb.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsencePage : ContentPage
	{
		StudentListViewModel studentListViewModel;
		public AbsencePage()
		{
			InitializeComponent();
			studentListViewModel = new StudentListViewModel();
			BindingContext = studentListViewModel;
		}

		//Student list checkbox changes
		private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			CheckBox box = (CheckBox)sender;
			var selectedStudentListItem = box.BindingContext as StudentListItem;
			selectedStudentListItem.check = box.IsChecked;
		}

		private void SaveAbsence(object sender, EventArgs e)
		{
			int absentStudent = 0;

			foreach (StudentListItem itm in studentListViewModel.Students)
			{
				if (itm.check)
					absentStudent++;
			}
		}
	}
}