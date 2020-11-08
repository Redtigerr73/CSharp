using System;

namespace ExHeroRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Arme gun= new Arme("gun",10);
            Arme missile = new Arme("missile", 5);

            Hero h1 = new Hero("Tata", 30, gun);
            Hero h2 = new Hero("Toto", 20, missile);

            h1.Duel(h2);

            Console.ReadLine();
        }
    }
}
