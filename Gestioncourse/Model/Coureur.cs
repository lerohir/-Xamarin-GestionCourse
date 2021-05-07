using System;
using System.Collections.Generic;
using System.Text;

namespace Gestioncourse.Model
{

    public class Coureur
    {
        private int _idCoureur;
        private string _prenom;
        private string _nom;
        private string _age;
        private bool _sexe; //1 = F, 0 = H
        private string _adr;
        private string _codePostal;
        private string _ville;

        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Age { get => _age; set => _age = value; }
        public bool Sexe { get => _sexe; set => _sexe = value; }
        public string Adr { get => _adr; set => _adr = value; }
        public string CodePostal { get => _codePostal; set => _codePostal = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int IdCoureur { get => _idCoureur; set => _idCoureur = value; }
    }
}
