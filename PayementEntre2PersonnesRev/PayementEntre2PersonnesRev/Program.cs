using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayementEntre2PersonnesRev
{
    class Program
    {
        static void Main(string[] args)
        {
            //interet d'instancier p1 et p2 ? 
            Banque ing = new Banque(12000);
            Banque fortis = new Banque(15000);

            Personne p1 = new Personne("gertrude", ing);
            Personne p2 = new Personne("jean", fortis);

            p1.Afficher();
            p2.Afficher();

            p1.Payer(p2, 500);

            p1.Afficher();
            p2.Afficher();

            Console.ReadLine();
        }
    }
}
