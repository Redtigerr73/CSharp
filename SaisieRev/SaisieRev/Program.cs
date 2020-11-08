using System;

namespace SaisieRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Saisie.LireString("Introduire une phrase SVP"));
            Console.WriteLine(Saisie.LireInt("Introduire un entier SVP"));
            Console.WriteLine(Saisie.LireBool("Introduire un bool SVP"));
        }
    }
}
