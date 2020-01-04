using System;
using System.Collections.Generic;
using GAb.viewmodel;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class AddStudentScreen : ContentPage
    {
        public AddStudentScreen()
        {
            InitializeComponent();
            BindingContext = new OptionsViewModel();
        }

    }
}
