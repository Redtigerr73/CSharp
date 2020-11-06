using System;

namespace ExHeroRev
{

    class Hero
    {
        #region Champ
        static De pointAttaque = new De();
        private string _nom;
        public string Nom
        {
            get => _nom;
            private set => _nom = value;
        }

        private int _pointVie;
        public int PointVie
        {
            get => _pointVie;
            set => _pointVie = value;
        }
        #endregion

        #region Constructeur
        //On utilise le Setter ou directement l'attribut dans le constructeur ?? _nom ou Nom
        public Hero(string nom, int pointVie)
        {
            Nom = nom;
            PointVie = pointVie;
        }
        #endregion

        #region Methode
        public void Attaquer(Hero victime)
        {
            Console.WriteLine($"Hero {Nom}, tu as {PointVie}, Hero {victime.Nom}, tu as {victime.PointVie}");
            int pointMoins = pointAttaque.Lancer();
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
