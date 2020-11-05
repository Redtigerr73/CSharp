using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeroRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h1 = new Hero("Tata",30);
            Hero h2 = new Hero("Toto", 20);

            h1.Duel(h1, h2);
        }
    }
}
