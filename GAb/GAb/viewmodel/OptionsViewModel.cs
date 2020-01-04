using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GAb.models;

namespace GAb.viewmodel
{
    class OptionsViewModel:ViewModelBase
    {
        public ObservableCollection<Option> Options { get; set; }

        public OptionsViewModel()
        {
            Options = new ObservableCollection<Option>();

            Options.Add(new Option("G.INFO"));
            Options.Add(new Option("GTR +"));
        }

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

    }
}
