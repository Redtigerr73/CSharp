using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erExerciceVoiture
{
    class Voiture
    {
        public string Marque;
        public string modele;
        public string numDeSerie;
        public double prixCat;
        public double reduction;
        public double prixReel;

        public Voiture(string marque, string modele, string numDeSerie, double prixCat)
        {
            Marque = marque;
            this.modele = modele;
            this.numDeSerie = numDeSerie;
            this.prixCat = prixCat;
        }

        public void CalculPrixReel(double reduction)
        {
            prixReel = prixCat - (prixCat * reduction);
        }

        public void Afficher()
        {
            Console.WriteLine($"La voiture {Marque} et modèle {modele} avec le numDeSerie {numDeSerie}, le prix réel est {prixReel} ");
        }

    }
}
