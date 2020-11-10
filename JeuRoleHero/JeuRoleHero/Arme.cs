using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoleHero
{
    class Arme
    {
        private string nomArme;
        private int Degat;

        public Arme(string nomArme, int degat)
        {
            this.nomArme = nomArme;
            Degat = degat;
        }

        public int GetDegat()
        {
            return Degat;
        }
    }
}
