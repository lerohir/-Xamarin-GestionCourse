using Gestioncourse.Model;
using Gestioncourse.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gestioncourse.ViewModel
{
    public class AddCoureurViewModel : BindableObject
    {
        private Coureur _coureur;
        

        public Coureur Coureur { get => _coureur; set { _coureur = value; OnPropertyChanged(); } }

        public Command Retour { get; set; }
        public Command AjouterConfiguration { get; set; }
        public INavigation Navigation { get; set; }

        public AddCoureurViewModel(INavigation navigation)
        {
            Retour = new Command(RetourAction);
            AjouterConfiguration = new Command(AjouterConfigurationAction);
            Navigation = navigation;
        }

        private void AjouterConfigurationAction(object obj)
        {
            App.ListCoureurs.Add(Coureur);
        }

        private void RetourAction(object obj)
        {
            Navigation.PopModalAsync();
        }
    }
}
