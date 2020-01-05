using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using GAb.dao;
using GAb.models;
using GAb.services;

namespace GAb.viewmodel
{

    class OptionsViewModel : BaseViewModel
    {
        public OptionDAO optionDAO;
        public List<Option> options;
        public OptionsViewModel()
        {
            Options = new List<Option>();
            optionDAO = new OptionDAO();
            fillOptions();
        }
        public List<Option> Options
        {
            get { return options; }
            private set
            {
                options = value;
                OnPropertyChanged();
            }
        }

        public async void fillOptions()
        {
            this.Options = await optionDAO.ListAsync();
        }
		
    }
}
