using System;
using System.Collections.Generic;
using System.Diagnostics;
using GAb.dao;
using GAb.models;

namespace GAb.viewmodel
{
    class AddLessonViewModel:BaseViewModel
    {
        public OptionDAO optionDAO;
        public List<Option> options;


        public AddLessonViewModel()
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
            ////Debug.Write("****************" + Options.Count);
            //foreach (Option o in Options)
            //{
            //    Debug.Write(o.title);
            //}
            ////Debug.Write("**********************************************");

        }
    }
}

