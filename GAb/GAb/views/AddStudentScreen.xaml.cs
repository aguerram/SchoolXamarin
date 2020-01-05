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
        public bool validateInputs(string cne,string lastname,string firstname,string email,string phone,Option option)
        {
            if(cne == null)
            {
                CustomAlert("cne");
                return false;
            }
            if (lastname == null)
            {
                CustomAlert("lastname");
                return false;
            }
            if (firstname == null)
            {
                CustomAlert("firstname");
                return false;
            }
            if (email == null)
            {
                CustomAlert("email");
                return false;
            }
            if (phone == null)
            {
                CustomAlert("phone");
                return false;
            }
            if (option == null)
            {
                CustomAlert("option");
                return false;
            }
            return true;

        }
        public void CustomAlert(string input)
        {
            DisplayAlert("Failed", "please fill in your " + input + " please", "try again!");
        }
        private async void saveStudentToDB(object sender, EventArgs e)
        {
            string cne = cneEntry.Text;
            string lastname = lastnameEntry.Text;
            string firstname = firstnameEntry.Text;
            string email = emailEntry.Text;
            string phoneNumber = (phoneEntry.Text);
            Option option =(Option)optionEntry.SelectedItem;
            if (!validateInputs(cne, lastname, firstname, email, phoneNumber, option))
            {
                return;
            }
            Student student = new Student(cne,firstname,lastname,email,phoneNumber,option.ID);
            bool saved = await studentService.saveStudentToDB(student);
            if (saved)
            {
                DisplayAlert("success", "added successfully", "okay");
            }else
            {
                DisplayAlert("failed", "An error occured", "try again!");
            }
            Debug.WriteLine("Optionnnnnn");
            Debug.WriteLine(option.title);

        }

    }
}
