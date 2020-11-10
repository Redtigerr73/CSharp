using System;

namespace ExHeroRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h1 = new Hero("Tata", 30);
            Hero h2 = new Hero("Toto", 20);
            Mage m1 = new Mage("Roi", 25, 5);

            m1.Duel(h1);

            Console.ReadLine();
        }
    }
}
