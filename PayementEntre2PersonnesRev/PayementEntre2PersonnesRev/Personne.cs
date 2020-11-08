using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementEntre2PersonnesRev
{
    class Personne
    {
        #region Champs
        private string _nom;
        #endregion

        #region Propriété
        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }
        public Banque Compte { get; private set; }
        #endregion

        #region Constructeur
        public Personne(string nom, Banque compte)
        {
            _nom = nom;
            Compte = compte;
            //_argent = argent;
        }
        #endregion

        #region Methode
        public void Payer(Personne personne, double montant)
        {
            this.Compte.Retrait(montant);
            personne.Compte.Versement(montant);
        }

        public void Afficher()
        {
            Console.WriteLine($"{Nom} vous avez {Compte.Solde} EUR sur votre compte");
        }
        #endregion 
    }
}
