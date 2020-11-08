namespace JeuRoleHero
{
    class Program
    {
        static void Main(string[] args)
        {
            Arme Bazzoka = new Arme("Bazzoka", 10);
            Arme Shotgun = new Arme("Shotgun", 12);

            Hero Bob = new Hero("Bob", 50, Bazzoka);
            Hero Marley = new Hero("Marley", 50, Shotgun);
            Arene ring = new Arene(Bob, Marley);

            ring.Duel();
        }
    }
}
