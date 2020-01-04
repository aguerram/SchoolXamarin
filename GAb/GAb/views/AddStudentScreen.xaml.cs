using System;
using System.Collections.Generic;
using GAb.viewmodel;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class AddStudentScreen : ContentPage
    {
        OptionsViewModel optionsViewModel;

        public AddStudentScreen()
        {
            InitializeComponent();
            optionsViewModel = new OptionsViewModel();
            optionsViewModel.fillOptions();
            BindingContext = optionsViewModel;
        }

    }
}
