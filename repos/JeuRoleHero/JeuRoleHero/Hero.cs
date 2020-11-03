using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoleHero
{
    class Hero
    {
        private String nom;
        private int PointVie;
        protected Des dice = new Des(2);
        protected int pointASoustraire;

        public Hero(string nom, int pointVie)
        {
            this.nom = nom;
            PointVie = pointVie;
        }

        public string GetNom ()
        {
            return this.nom;
        }

        public int GetPointVie ()
        {
            return this.PointVie;
        }

        public void SetPointVie (int point)
        {
            this.PointVie = point;
        }

        public virtual void Attaquer(Hero victime)
        {
            dice.Lancer();
            int pointASoustraire = dice.Lire();
            victime.SetPointVie(victime.GetPointVie() - pointASoustraire);
            Console.WriteLine($"{this.GetNom()} vient d'attaquer {victime.GetNom()} en lui enlevant {pointASoustraire}, il ne reste plus que {victime.GetPointVie()} points de vie");
        }

        public virtual void Duel (Hero victime)
        {
            do
            {
                Attaquer(victime);

                if(victime.GetPointVie() > 0)
                victime.Attaquer(this);
            }
            while ( (this.GetPointVie() > 0) && (victime.GetPointVie() > 0) );
        }
    }
}
