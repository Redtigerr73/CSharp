using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeroRev
{
    class Arme
    {
        #region Champ

        private string _nom;
        private int _bonus;


        #endregion

        #region Propriétés

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        #endregion

        #region Constructeur

        public Arme(string nom, int bonus)
        {
            Nom = nom;
            Bonus = bonus;
        }

        #endregion

        #region Méthode
        public void Afficher()
        {
            Console.WriteLine($"L'arme utilisé est {Nom} les dégats bonus sont de {Bonus}");
        }
        #endregion
    }
}
