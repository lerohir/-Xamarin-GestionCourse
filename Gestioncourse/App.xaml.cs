using Gestioncourse.Model;
using Gestioncourse.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestioncourse
{
    public partial class App : Application
    {
        //Liste contenant les objets de la class model Course.cs
        public static List<Course> ListCourses { get; set; }
        public App()
        {
            InitializeComponent();

            //Verifie l'existance de la course
            if (ListCourses == null)
                ListCourses = new List<Course>();

            InitListCourse();

            //demarrage de la vue concerné 
            MainPage = new ListeCourses();
        }
        private static void InitListCourse()
        {
            // Ajout d'un objet course dans la listCourses en utilisatn le constructeur par default
            ListCourses.Add(new Course { IdCourse = 0, Nom = "Lieu 1", Date = "12/12/2012", Distance = 30, HeureDepart = "12h30" });
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
