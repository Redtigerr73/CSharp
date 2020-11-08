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
        private Voiture _voiture;
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

        public Voiture Voiture { get; private set; }

        public Personne Conjoint
        {
            get { return _conjoint; }
            set { _conjoint = value; }
        }
        #endregion

        #region Constructeur
        public Personne(string nom, string prenom, /*DateTime dateNaissance*/string dateNaissance)
            //prévoir une possibilité nulle ou prévoir un nouveau constructeur ?
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public Personne(string nom, string prenom, string dateNaissance, Voiture voiture)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Voiture = voiture;
        }
        #endregion

        #region Methode
        public void AcheterVoiture(Personne vendeur)
        {
            if (vendeur.Voiture != null)
            {
                Voiture = vendeur._voiture;
                Console.WriteLine($"{Prenom} vous venez d'acheter la voiture {Voiture.Marque} {Voiture.Model} de {vendeur.Prenom}{vendeur.Nom}");
                vendeur.Voiture = null;
                Console.WriteLine($"{vendeur._prenom} vous ne possédez plus la voiture");
            }
            else Console.WriteLine("Il n'y a pas de voiture à acheter");
        }
        #endregion
    }
}
