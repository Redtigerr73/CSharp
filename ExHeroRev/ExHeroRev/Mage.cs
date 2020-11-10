using System;
namespace ExHeroRev
{
    class Mage : Hero
    {
        #region Champ

        private int _puissance;



        #endregion

        #region Propriété

        public int Puissance
        {
            get { return _puissance; }
            private set { _puissance = value; }
        }

        #endregion

        #region Constructeur
        public Mage(string nom, int pointVie, int puissance) : base(nom, pointVie) //pas très bien compris pourquoi définir la base
        {
            Puissance = LanceMage(puissance);
        }
        #endregion

        #region Methode
        public new void Attaquer(Hero victime)
        {
                Console.WriteLine($"Hero {Nom}, tu as {PointVie}, Hero {victime.Nom}, tu as {victime.PointVie}");
                int pointMoins = pointAttaque.Lancer();
                victime.PointVie -= pointMoins;
                Console.WriteLine($"Hero {this.Nom} attaque {victime.Nom} en lui enlevant {pointMoins} de vie");
        }

        public int LanceMage(int puissance)
        {
            int p = 0;
            for (int i = 0; i < puissance; i++)
            {
                p += pointAttaque.Lancer();
            }
            return p;
        }
        #endregion
    }
}
