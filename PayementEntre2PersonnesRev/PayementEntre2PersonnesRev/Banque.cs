using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementEntre2PersonnesRev
{
    class Banque
    {
        #region Propriétés
        public double Solde { get; private set; }
        #endregion

        #region Constructeur
        public Banque(double solde)
        {
            Solde = solde;
        }
        #endregion

        #region Méthode
        public void Retrait(double montant)
        {
            if (montant > 0)
            {
                if (Solde - montant >= 0)
                    Solde -= montant;
                else
                    Console.WriteLine("Pas assez d'argent.");
            }
            else
                Console.WriteLine("Le montant est négatif ou égal à zéro.");
        }

        public void Versement(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
            else
                Console.WriteLine("Le montant est négatif ou égal à zéro.");
        }
        #endregion
    }
}
