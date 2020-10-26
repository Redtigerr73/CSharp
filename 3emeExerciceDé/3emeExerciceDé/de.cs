using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3emeExerciceDé
{
    class De
    {
        public int Valeur;
        public int NbLancee;
        public Random rng = new Random();

        public De(int nbLancee, int valeur = 1)
        {
           Valeur = valeur;
           NbLancee = nbLancee;
        }


        public void Lancer()
        {
            for (int i = 0; i <= NbLancee; i++)
            {
                Valeur = rng.Next(1,7);
            }
            
        }

        public int Lire()
        {
            return Valeur;
        }

        public void Afficher()
        {
            Console.WriteLine(Valeur);
        }
        




    }
}
