using System;
using System.Collections.Generic;
using System.Text;

namespace Gestioncourse.Model
{
    class Inscription
    {
        private int _idCoureur;
        private int _idCourse;

        public int IdCoureur { get => _idCoureur; set => _idCoureur = value; }
        public int IdCourse { get => _idCourse; set => _idCourse = value; }
    }
}
