using System;

namespace ExHeroRev
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Arme gun= new Arme("gun",10);
            Arme missile = new Arme("missile", 5);

            Hero h1 = new Hero("Tata", 30, gun);
            Hero h2 = new Hero("Toto", 20, missile);
=======
            Hero h1 = new Hero("Tata", 30);
            Hero h2 = new Hero("Toto", 20);
>>>>>>> 989b9f6499c4b522d296bcdbd44d24294eccaa44

            h1.Duel(h2);

            Console.ReadLine();
        }
    }
}
