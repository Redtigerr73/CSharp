using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erExerciceVoiture
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voitureMomo = new Voiture("VW","GOLF","BE12345",25000.0);
            voitureMomo.CalculPrixReel(0.1);
            voitureMomo.Afficher();

        }
    }

    
}
