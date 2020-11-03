using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseStatiqueLireString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Va appeler LireString D'abord afficher le texte introdui
            Console.WriteLine(Saisie.LireString("Entrer votre message d'amour"));

            //Va appeler Lire entier qui va appeler lire string et le Afficher le numéro favoris
            Console.WriteLine(Saisie.LireEntier("Entrer votre numéro favoris"));

            //Va appeler Lire Boolean et gerer les erreurs égalements
            Console.WriteLine(Saisie.LireBoolean("Entrer un boolean") );
        }
    }
}
