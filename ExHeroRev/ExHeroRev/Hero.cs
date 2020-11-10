using System;

namespace ExHeroRev
{

    class Hero
    {
        #region Champ
        protected static De pointAttaque = new De();
        private string _nom;
        private int _pointVie;

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

        public Arme Arme { get; private set; }
        #endregion

        #region Constructeur
        public Hero(string nom, int pointVie)
        {
            Nom = nom;
            PointVie = pointVie;
        }
        public Hero(string nom, int pointVie, Arme arme)
        {
            Nom = nom;
            PointVie = pointVie;
            Arme = arme;
        }

        #endregion

        #region Methode
        public void Attaquer(Hero victime)
        {
            // préparer 2 attaquer , avec une condition if vérifier la classe si y a une Arme ou pas d'Arme (nulle)
            Console.WriteLine($"Hero {Nom}, tu as {PointVie}, Hero {victime.Nom}, tu as {victime.PointVie}, tu utilises {Arme.NomArme}");
            int pointMoins = pointAttaque.Lancer() + Arme.BonusArme;
            victime.PointVie -= pointMoins;
            Console.WriteLine($"Hero {this.Nom} attaque {victime.Nom} en lui enlevant {pointMoins} de vie");
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
