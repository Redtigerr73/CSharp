using System;

namespace ExHeroRev
{

    class Hero
    {
        #region Champ
        static De pointAttaque = new De(); // plus utile d'utiliser en statique ou dans la méthode attaquer ?
        private string _nom;
        private int _pointVie;
        protected Arme ArmeHero;
         
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
            ArmeHero = arme;
        } // est-il utile de faire un autre constructeur avec string nomArme, string degatBonus, si oui comment le faire relier à l'objet arme ?
        #endregion

        #region Methode
        public void Attaquer(Hero victime)
        {
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
