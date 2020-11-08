using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne("Toto", "Tata");
            Personne p2 = new Personne("Titi", "Tutu");

            Belge p3 = new Belge("Jean", "Frite", "Bruxellois");
            p1.Afficher();
            p3.Afficher();
            p3.Afficher();
            
        }
    }
}
