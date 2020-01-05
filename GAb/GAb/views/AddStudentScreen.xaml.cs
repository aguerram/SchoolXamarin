using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using GAb.models;
using GAb.services;
using GAb.viewmodel;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class AddStudentScreen : ContentPage
    {
        OptionsViewModel optionsViewModel;
        StudentService studentService;
        public AddStudentScreen()
        {
            InitializeComponent();
            optionsViewModel = new OptionsViewModel();
            studentService = new StudentService();
            BindingContext = optionsViewModel;
        }
        
        private async void saveStudentToDB(object sender, EventArgs e)
        {
            string cne = cneEntry.Text;
            string lastname = lastnameEntry.Text;
            string firstname = firstnameEntry.Text;
            string email = emailEntry.Text;
            string phoneNumber = (phoneEntry.Text);
            Option option =(Option)optionEntry.SelectedItem;
			if(option == null)
			{
				Student student = new Student(cne, firstname, lastname, email, phoneNumber, option.ID);
				bool saved = await studentService.saveStudentToDB(student);
				if (saved)
				{
					DisplayAlert("success", "added successfully", "okay");
					cneEntry.Text = "";
					lastnameEntry.Text = "";
					firstnameEntry.Text = "";
					emailEntry.Text = "";
					phoneEntry.Text = "";
				}
				else
				{
					DisplayAlert("failed", "An error occured", "try again!");
				}
				Debug.WriteLine(option.title);
			}
			else
			{
				DisplayAlert("Error", "Please select an option","Try again");
			}

        }


    }
}
