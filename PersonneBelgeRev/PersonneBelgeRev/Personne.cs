using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeRev
{
    class Personne
    {
        #region Champs
        protected string _nom;
        protected string _prenom;
        #endregion

        #region Propriétés
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
        #endregion

        #region Constructeur
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        #endregion

        #region Méthode
        public void Afficher()
        {
            Console.WriteLine($"Nom : {Nom} et Prénom : { Prenom}");
        }
        #endregion
    }
}
