using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAssociation
{
    class Voiture
    {
        private string Marque;
        private Moteur Mot;
        public Voiture(string Marque, string TypeMoteur, string PuissanceMot)
        {
            this.Marque = Marque;
            Mot = new Moteur(TypeMoteur, PuissanceMot);
        }
        public Voiture(string Marque, Moteur Mot)
        {
            this.Marque = Marque;
            this.Mot = Mot;
        }
        public void Afficher()
        {
            Console.Write("Marque: " + Marque + " Moteur ");
            Mot.Afficher();
        }
    }
}
