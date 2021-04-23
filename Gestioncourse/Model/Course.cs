using System;
using System.Collections.Generic;
using System.Text;

namespace Gestioncourse.Model
{
    public class Course
    {
        private int _idCourse;
        private string _nom;
        private string _date;
        private int _distance;
        private string _heureDepart;
        //private List<Coureur> _coureur;

        public int IdCourse { get => _idCourse; set => _idCourse = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Date { get => _date; set => _date = value; }
        public int Distance { get => _distance; set => _distance = value; }
        public string HeureDepart { get => _heureDepart; set => _heureDepart = value; }
    }
}
