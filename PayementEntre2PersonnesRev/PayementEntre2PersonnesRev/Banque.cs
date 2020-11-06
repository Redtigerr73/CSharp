using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementEntre2PersonnesRev
{
    class Banque
    {
        #region Champ
        //private Personne _p1;
        //private Personne _p2;
        #endregion

        #region Propriétés
        public double Solde { get; private set; }
        #endregion

        //Faut il d'office un constructeur, je n'ai pas besoin de p1 et p2 avant la méthode payer
        #region Constructeur
        public Banque(double solde)
        {
            Solde = solde;
        }
        #endregion

        #region Méthode
        public void Retrait(/*Personne originateur, Personne beneficiaire, */double montant)
        {
            //Console.WriteLine($"Payement de {originateur.Nom} vers {beneficiaire.Nom} de {montant} EUR");
            //if (originateur.Argent - montant > 0)
            //{
            //    originateur.Argent -= montant;
            //    beneficiaire.Argent += montant;
            //    Console.WriteLine("Transaction réussie");
            //    originateur.Afficher();
            //    beneficiaire.Afficher();
            //}
            //else
            //{
            //    Console.WriteLine("Transaction impossible");
            //    originateur.Afficher();
            //    beneficiaire.Afficher();
            //}
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
