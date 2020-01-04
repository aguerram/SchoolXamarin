using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using GAb.models;
using GAb.services;

namespace GAb.viewmodel
{

    class OptionsViewModel : BaseViewModel
    {
        StudentService studentService;
        public List<Option> Options { get; set; }


        public OptionsViewModel()
        {
            studentService = new StudentService();
            fillOptions();
        }
        public async Task<int> fillOptions()
        {
            this.Options = await studentService.optionDAO.ListAsync();
            return 1;
        }
    }
}
