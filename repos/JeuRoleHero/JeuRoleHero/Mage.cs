using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoleHero
{
    class Mage : Hero
    {
        protected int _puissance;
        public Mage(string nom, int pointVie, int puissance) : base(nom, pointVie)
        {
            _puissance = puissance;
        }

        public override void Attaquer(Hero victime)
        {
            for (int i = 0; i < _puissance; i++)
            {
                dice.Lancer();
                pointASoustraire += dice.Lire();
            }
            victime.SetPointVie(victime.GetPointVie() - pointASoustraire);
            Console.WriteLine($"{this.GetNom()} vient d'attaquer {victime.GetNom()} en lui enlevant {pointASoustraire}, il ne reste plus que {victime.GetPointVie()} points de vie");
        }

        //public new void Duel(Hero victime)
        //{
        //    do
        //    {
        //        Attaquer(victime);

        //        victime.Attaquer(this);
        //    }
        //    while ((this.GetPointVie() > 0) && (victime.GetPointVie() > 0));
        //}
    }
}
