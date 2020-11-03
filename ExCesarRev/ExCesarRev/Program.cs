using System;

namespace ExCesarRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Cesar message = new Cesar(3);
            string msgChiffre = message.Chiffrer("toto");
            Console.WriteLine("Le message a chiffrer est : toto");
            Console.WriteLine($"Le message chiffré est : {msgChiffre}");
            Console.WriteLine($"Le message déchiffré est : {message.Dechiffrer(msgChiffre)}");
        }
    }
}
