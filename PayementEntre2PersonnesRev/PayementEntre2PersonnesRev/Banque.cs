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
        private Personne _p1;
        private Personne _p2;
        #endregion

        //Faut il d'office un constructeur, je n'ai pas besoin de p1 et p2 avant la méthode payer
        #region Constructeur
        public Banque(Personne p1, Personne p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        #endregion

        #region Méthode
        public void Payer(Personne originateur, Personne beneficiaire, double montant)
        {
            Console.WriteLine($"Payement de {originateur.Nom} vers {beneficiaire.Nom} de {montant} EUR");
            if (originateur.Argent - montant > 0)
            {
                originateur.Argent -= montant;
                beneficiaire.Argent += montant;
                Console.WriteLine("Transaction réussie");
                originateur.Afficher();
                beneficiaire.Afficher();
            }
            else
            {
                Console.WriteLine("Transaction impossible");
                originateur.Afficher();
                beneficiaire.Afficher();
            }

        }
        #endregion
    }
}
