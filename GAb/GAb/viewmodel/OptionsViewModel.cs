using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using GAb.dao;
using GAb.models;
using GAb.services;

namespace GAb.viewmodel
{

    class OptionsViewModel : BaseViewModel
    {
        public OptionDAO optionDAO;
        public List<Option> Options { get; set; }


        public OptionsViewModel()
        {
			optionDAO = new OptionDAO();
			Options = new List<Option>();
			fillOptions();
        }
        public async void fillOptions()
        {
			this.Options = await optionDAO.ListAsync();
        }
		
    }
}
