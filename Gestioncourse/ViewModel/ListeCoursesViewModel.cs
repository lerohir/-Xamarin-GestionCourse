using Gestioncourse.Model;
using Gestioncourse.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gestioncourse.ViewModel
{
    public class ListeCoursesViewModel : BindableObject
    {
        private List<Course> _courses;

        public List<Course> Courses { get => _courses; set { _courses = value; OnPropertyChanged();}}

        public Command ActionNavigation { get; set; } //Ref au binding de Command dans le XAML ListeCourse
        public INavigation Navigation;
        
        
        //Constructeur
        public ListeCoursesViewModel(INavigation navigation)
        {
            if (Courses == null)
            {
                Courses = new List<Course>();
            }

            Courses = App.ListCourses;

            Navigation = navigation;
            ActionNavigation = new Command(GoNavigation);
        }

        private void GoNavigation(object obj)
        {
            Navigation.PushModalAsync(new AddCoureur());
            //Navigation.PopModalAsync(new AddCoureur());
        }

        public void AfficherView_RemplirCourse(Course course)
        {
            Navigation.PushModalAsync(new RemplirCourse(course));

        }
    }
}
