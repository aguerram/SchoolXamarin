using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GAb.models;

namespace GAb.viewmodel
{
<<<<<<< HEAD
    class OptionsViewModel:ViewModelBase
    {
=======
    class OptionsViewModel : BaseViewModel
    {

>>>>>>> 586be253f16d36b7a3dfba3d5648ae1a8ac8e7a9
        public ObservableCollection<Option> Options { get; set; }

		public OptionsViewModel()
        {
            Options = new ObservableCollection<Option>();

            Options.Add(new Option("G.INFO"));
            Options.Add(new Option("GTR +"));
        }

<<<<<<< HEAD
        Option selectedOption;
        public Option SelectedOption
        {
            get { return selectedOption; }
            set
            {
                if (selectedOption != value)
                {
                    selectedOption = value;
                    OnPropertyChanged();
                }
            }
        }

=======
>>>>>>> 586be253f16d36b7a3dfba3d5648ae1a8ac8e7a9
    }
}
