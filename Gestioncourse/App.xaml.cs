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
        public static List<Coureur> ListCoureurs { get; set; }
        public App()
        {
            InitializeComponent();

            //Verifie l'existance de la course
            if (ListCourses == null)
                ListCourses = new List<Course>();
            if (ListCoureurs == null)
                ListCoureurs = new List<Coureur>();

            InitListCourse();
            InitListCoureur();

            //demarrage de la vue concerné 
            MainPage = new ListeCourses();


        }

        private void InitListCoureur()
        {
            ListCoureurs.Add(new Coureur {IdCoureur= 0, Nom = "Herbin", Prenom = "Elie", Age = "20", Sexe = false /*Homme*/, CodePostal = "59400", Ville = "Cambrai", Adr = "910 avenue du cateau" });
            ListCoureurs.Add(new Coureur {IdCoureur = 1, Nom = "Robert", Prenom = "Dupont", Age = "30", Sexe = false /*Homme*/, CodePostal = "59400", Ville = "Cambrai", Adr = "12 rue Jean Jaures" });
            
        }

        private static void InitListCourse()
        {
            // Ajout d'un objet course dans la listCourses en utilisatn le constructeur par default
            ListCourses.Add(new Course { IdCourse = 0, Nom = "Lieu 1", Date = "12/12/2012", Distance = 20, HeureDepart = "12h20" });
            ListCourses.Add(new Course { IdCourse = 1, Nom = "Lieu 2", Date = "33/33/2033", Distance = 30, HeureDepart = "13h30" });

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
