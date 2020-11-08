using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneCommuneRev
{
    class Personne
    {
        #region Champ
        private string _nom;
        private string _prenom;
        private string _dateNaissance;
        protected Voiture _voiture;
        private Personne _conjoint;


        
        #endregion

        #region Propriété
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public Personne Conjoint
        {
            get { return _conjoint; }
            set { _conjoint = value; }
        }
        #endregion

        #region Constructeur
        public Personne(string nom, string prenom, /*DateTime dateNaissance*/string dateNaissance, Voiture voiture=null, Personne conjoint=null )
            //prévoir une possibilité nulle ou prévoir un nouveau constructeur ?
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            _voiture = voiture;
            

        }
        #endregion

        #region Methode
        public void AcheterVoiture(Personne vendeur)
        {
            if (vendeur._voiture != null)
            {
                _voiture = vendeur._voiture;
                Console.WriteLine($"{_prenom} vous venez d'acheter la voiture {_voiture.Marque} {_voiture.Model} de {vendeur._prenom}{vendeur._nom}");
                vendeur._voiture = null;
                Console.WriteLine($"{vendeur._prenom} vous ne possédez plus la voiture");
            }
            else Console.WriteLine("Il n'y a pas de voiture à acheter");
        }
        #endregion
    }
}
