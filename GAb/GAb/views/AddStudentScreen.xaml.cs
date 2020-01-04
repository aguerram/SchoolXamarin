using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GAb.views
{
    public partial class AddStudentScreen : ContentPage
    {
        List<string> options = new List<string>();
        public AddStudentScreen()
        {
            InstanciateOptions();
            InitializeComponent();
        }
        public void InstanciateOptions()
        {
            options.Add("Genie informatique");
            options.Add("Genie telecome et reseaux");
            options.Add("Genie industriel");
            options.Add("Genie procedés");
        }
    }
}
