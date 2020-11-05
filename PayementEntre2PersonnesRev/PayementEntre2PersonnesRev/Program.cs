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
            Personne p1 = new Personne("gertrude",1459.25);
            Personne p2 = new Personne("jean", 2500.25);
            //interet d'instancier p1 et p2 ? 
            Banque ing = new Banque(p1,p2);
            ing.Payer(p1, p2, 400);


        }
    }
}
