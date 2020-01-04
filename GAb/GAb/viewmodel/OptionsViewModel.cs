using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GAb.models;

namespace GAb.viewmodel
{
    public class OptionsViewModel : BaseViewModel
    {
        private ObservableCollection<Option> options;

        public ObservableCollection<Option> Options { get => options; set => options = value; }

        public OptionsViewModel()
        {
            Options = new ObservableCollection<Option>();

            Options.Add(new Option("G.INFO"));
            Options.Add(new Option("GTR +"));

        }


        //Option selectedOption;
        //public Option SelectedOption
        //{
        //    get { return SelectedOption; }
        //    set
        //    {
        //        if (SelectedOption != value)
        //        {
        //            SelectedOption = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        //public void InstanciateOptions()
        //{
        //    OptionData.Add(new Option("Genie informatique"));
        //    OptionData.Add(new Option("Genie telecome et reseaux"));
        //    OptionData.Add(new Option("Genie industriel"));
        //    OptionData.Add(new Option("Genie procedés"));
        //}
    }
}
