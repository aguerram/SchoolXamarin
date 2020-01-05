using System;
using System.Collections.Generic;
using GAb.models;
using GAb.services;
using GAb.viewmodel;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class AddNewLessonScreen : ContentPage
    {
        AddLessonViewModel addLessonView;
        LessonService lessonService;
        public AddNewLessonScreen()
        {
            InitializeComponent();
            addLessonView = new AddLessonViewModel();
            lessonService = new LessonService();
            BindingContext = addLessonView;
        }
       public bool InputValidation(string lessonNameValue, Option optionValue)
       {
            if (lessonNameValue == null)
            {
                DisplayAlert("Wrong Inputs!", "please enter lesson's title", "try again!");
                return false;
            }
            if (optionValue == null)
            {
                DisplayAlert("Wrong Inputs!", "please enter the option for this lesson", "try again!");
                return false;
            }
            return true;
        }
        private async void saveLessonToDB(object sender, EventArgs e)
        {
            string lessonNameValue = lessonName.Text;
            Option optionValue = (Option) optionPicker.SelectedItem;
            int teacher_id = App.currentTeacher.ID;
            Lesson lesson = new Lesson(lessonNameValue,teacher_id,optionValue.ID);
            if(!InputValidation(lessonNameValue, optionValue))
            {
                return;
            }


            if (await lessonService.AddLessonToDB(lesson))
            {
                await DisplayAlert("success", "Lesson added successfully","Okay");
            }
            else
            {
                await DisplayAlert("error", "An error occured, Please try again!", "try again!");
            }
        }

    }
}
