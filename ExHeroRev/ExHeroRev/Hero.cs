using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeroRev
{
    
    class Hero
    {
        #region Champ
        static De pointAttaque = new De();
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            private set { _nom = value; }
        }

        private int _pointVie;
        public int PointVie
        {
            get { return _pointVie; }
            set { _pointVie = value; }
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
        public void Attaquer(Hero attaquant, Hero victime)
        {
            Afficher(attaquant);
            Afficher(victime);
            int pointMoins = pointAttaque.Lancer();
            victime.PointVie -= pointMoins;
            Console.WriteLine($"Hero {attaquant.Nom} attaque {victime.Nom} en lui enlevant {pointMoins} de vie");
        }

        public void Duel(Hero attaquant, Hero victime)
        {
            do
            {
                Attaquer(attaquant, victime);
                if (victime.PointVie > 0)
                Attaquer(victime, attaquant);
            }
            while (victime.PointVie > 0 && attaquant.PointVie > 0);
        }
        public void Afficher(Hero h)
        {
            Console.WriteLine($"Hero {h.Nom}, tu as {h.PointVie}");
        }
        #endregion

    }
}
