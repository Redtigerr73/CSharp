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

<<<<<<< HEAD
        private string _nom;
        private int _bonus;
=======
        private string _nomArme;
        private int _bonusArme;
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44


        #endregion

        #region Propriétés

<<<<<<< HEAD
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
=======
        public string NomArme
        {
            get { return _nomArme; }
            set { _nomArme = value; }
        }
        public int BonusArme
        {
            get { return _bonusArme; }
            set { _bonusArme = value; }
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44
        }

        #endregion

        #region Constructeur

<<<<<<< HEAD
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
=======
        public Arme(string nomArme, int bonusArme)
        {
            NomArme = nomArme;
            BonusArme = bonusArme;
        }

        #endregion
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44
    }
}
