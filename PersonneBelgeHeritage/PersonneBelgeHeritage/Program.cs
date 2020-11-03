using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne citoyen = new Personne("francois", "koeune");

            Personne citoyenLambda = new Belge("frite", "mayonnaise", "Flamand");
            
            Belge citoyenBelge = new Belge("pierre", "paul", "Wallon");

            citoyen.Afficher();
            citoyenBelge.Afficher();
            citoyenLambda.Afficher();
            


        }
    }
}
