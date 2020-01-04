using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GAb.models;

namespace GAb.viewmodel
{
    class OptionsViewModel : BaseViewModel
    {

        public ObservableCollection<Option> Options { get; set; }

		public OptionsViewModel()
        {
            Options = new ObservableCollection<Option>();

            Options.Add(new Option("G.INFO"));
            Options.Add(new Option("GTR +"));

        }

    }
}
