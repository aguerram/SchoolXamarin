using System;
using System.Collections.Generic;
using GAb.models;

namespace GAb.viewmodel
{
    public class OptionsViewModel:BaseViewModel
    {
        List<Option> OptionData = new List<Option>();
        public IList<Option> Options { get { return OptionData; } }

        Option selectedOption;
        public Option SelectedOption
        {
            get { return SelectedOption; }
            set
            {
                if (SelectedOption != value)
                {
                    SelectedOption = value;
                    OnPropertyChanged();
                }
            }
        }
        public void InstanciateOptions()
        {
            OptionData.Add(new Option("Genie informatique"));
            OptionData.Add(new Option("Genie telecome et reseaux"));
            OptionData.Add(new Option("Genie industriel"));
            OptionData.Add(new Option("Genie procedés"));
        }
    }
}
