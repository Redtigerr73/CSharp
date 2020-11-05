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
        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        private double _argent;
        public double Argent
        {
            get { return _argent; }
            private set { _argent = value; }
        }
        #endregion

        #region Constructeur
        public Personne(string nom, double argent)
        {
            _nom = nom;
            _argent = argent;
        }
        #endregion

        #region Methode
        public void Afficher()
        {
            Console.WriteLine($"{_nom} vous avez {_argent} sur votre compte");
        }
        #endregion 
    }
}
