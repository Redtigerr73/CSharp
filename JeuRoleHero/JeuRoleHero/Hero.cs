using System;

namespace JeuRoleHero
{
    class Hero
    {
        private String nom;
        private int PointVie;
        static Des dice = new Des();
        Arme Arme;


        public Hero(string nom, int pointVie, Arme arme)
        {
            this.nom = nom;
            PointVie = pointVie;
            Arme = arme;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetPointVie()
        {
            return this.PointVie;
        }

        public void SetPointVie(int point)
        {
            this.PointVie = point;
        }

        public void Attaquer(Hero victime)
        {
            dice.Lancer();
            int pointASoustraire = dice.Lire() + this.Arme.GetDegat();
            victime.SetPointVie(victime.GetPointVie() - pointASoustraire);
            Console.WriteLine($"{this.GetNom()} vient d'attaquer {victime.GetNom()} en lui enlevant {pointASoustraire}, il ne reste plus que {victime.GetPointVie()} points de vie");

        }


    }
}
