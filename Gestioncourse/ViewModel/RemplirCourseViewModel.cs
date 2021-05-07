using Gestioncourse.View;
using Gestioncourse.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gestioncourse.ViewModel
{
    class RemplirCourseViewModel : BindableObject
    {

        public INavigation Navigation { get; set; }


        //Binding Command
        public Command AjoutCoureur { get; set; }
        public Command Retour { get; set; }

        private List<Coureur> _coureursParticipants;
        private List<Coureur> _listCoureurs;
        

        //Affichage course selectionné
        private string _nomCourse;
        private string _distanceCourse;
        private string _dateCourse;
        private string _heureDepartCourse;
        private int _selectCoureur;



        public List<Coureur> CoureursParticipants { get => _coureursParticipants; set { _coureursParticipants = value; OnPropertyChanged(); } }
        public List<Coureur> ListCoureurs { get => _listCoureurs; set { _listCoureurs = value; OnPropertyChanged(); } }
        public int SelectCoureur { get => _selectCoureur; set { _selectCoureur = value; OnPropertyChanged(); } }
        public string NomCourse { get => _nomCourse; set { _nomCourse = value; OnPropertyChanged(); } }
        public string DistanceCourse { get => _distanceCourse; set { _distanceCourse = value; OnPropertyChanged(); } }
        public string DateCourse { get => _dateCourse; set { _dateCourse = value; OnPropertyChanged(); } }
        public string HeureDepartCourse { get => _heureDepartCourse; set { _heureDepartCourse = value; OnPropertyChanged(); } }
        


        public RemplirCourseViewModel(INavigation navigation, Course course)
        {
            //Bouton Retour
            Retour = new Command(RetourAction);

            //Bouton Ajouter
            AjoutCoureur = new Command(ajoutCoureur); 


            Navigation = navigation;
            if (ListCoureurs == null)
            {
                ListCoureurs = new List<Coureur>();
            }
            
            ListCoureurs = App.ListCoureurs;
                 

            if (CoureursParticipants == null)
            {
                CoureursParticipants = new List<Coureur>();
            }

            NomCourse = "Nom : " + course.Nom;
            DistanceCourse = "Distance : " + Convert.ToString(course.Distance) + " km/h";
            DateCourse = "Date : " + course.Date;
            HeureDepartCourse = "Heure = " + course.HeureDepart;   

        }

        private void ajoutCoureur(object obj)
        {
            Coureur c1 = ListCoureurs[SelectCoureur];

            //Voir d'abord modèle inscription 
        }

        private void RetourAction(object obj)
        {
            Navigation.PopModalAsync();
        }
    }
}
