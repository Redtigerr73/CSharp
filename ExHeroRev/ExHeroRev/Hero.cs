using System;

namespace ExHeroRev
{

    class Hero
    {
        #region Champ
<<<<<<< HEAD
        static De pointAttaque = new De(); // plus utile d'utiliser en statique ou dans la méthode attaquer ?
        private string _nom;
        private int _pointVie;
        protected Arme ArmeHero;
=======
        static De pointAttaque = new De();
        private string _nom;
        private int _pointVie;
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44
         
        #endregion

        #region Propriétés
        public string Nom
        {
            get => _nom;
            private set => _nom = value;
        }

        public int PointVie
        {
            get => _pointVie;
            set => _pointVie = value;
        }

        #endregion

        #region Constructeur
        public Hero(string nom, int pointVie, Arme arme)
        {
            Nom = nom;
            PointVie = pointVie;
<<<<<<< HEAD
            ArmeHero = arme;
        } // est-il utile de faire un autre constructeur avec string nomArme, string degatBonus, si oui comment le faire relier à l'objet arme ?
=======

        }
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44
        #endregion

        #region Methode
        public void Attaquer(Hero victime)
        {
<<<<<<< HEAD
            int pointMoins = pointAttaque.Lancer();
                int bonus;
            if (ArmeHero != null)
                {
                bonus = ArmeHero.Bonus;
                pointMoins += bonus;
                ArmeHero.Afficher();
                }
            Console.WriteLine($"Hero {Nom}, tu as {PointVie}, Hero {victime.Nom}, tu as {victime.PointVie}");
            
            
            Console.WriteLine($"Hero {this.Nom} attaque {victime.Nom} en lui enlevant {pointMoins} de vie");
            victime.PointVie -= pointMoins;
=======
            Console.WriteLine($"Hero {Nom}, tu as {PointVie}, Hero {victime.Nom}, tu as {victime.PointVie}");
            int pointMoins = pointAttaque.Lancer();
            victime.PointVie -= pointMoins;
            Console.WriteLine($"Hero {this.Nom} attaque {victime.Nom} en lui enlevant {pointMoins} de vie");
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44
        }

        public void Duel(Hero victime)
        {
            do
            {
                Attaquer(victime);
                if (victime.PointVie > 0)
                {
                    victime.Attaquer(this);
                }
            }
            while (victime.PointVie > 0 && PointVie > 0);
        }
        #endregion

    }
}
