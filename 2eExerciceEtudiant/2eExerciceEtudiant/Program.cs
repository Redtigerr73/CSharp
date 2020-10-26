using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2eExerciceEtudiant
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant student = new Etudiant("Momo",2,0,13,16);
            student.Moyenne();
            student.Resultat();
            student.Afficher();
        }
    }

}
