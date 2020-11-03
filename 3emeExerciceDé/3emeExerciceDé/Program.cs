using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3emeExerciceDé
{
    class Program
    {
        static void Main(string[] args)
        {
            De dice = new De(4);
            dice.Lancer();
            Console.WriteLine( dice.Lire() );
            dice.Afficher();

            De De1 = new De(2);

            De1.Lancer();
            Console.WriteLine("Le fait de lancer le dé n'affiche rien: un résultat a été choisi, que l'on pourra lire par après");
            Console.WriteLine("J'ai tiré un : " + De1.Lire());
            Console.WriteLine("Si je regarde à nouveau le dé sans le relancer, je vois toujours que j'ai tiré un " + De1.Lire());
            De1.Lancer();
            Console.WriteLine("Je peux évidemment relancer le même dé: cette fois j'ai tiré un : " + De1.Lire());
            De De2 = new De(3);
            Console.WriteLine("Si on décide de lire un dé sans même le lancer, on voit que l'objet a été créé dans un état cohérent: en ce moment son résultat vaut : " + De2.Lire());
        }
    }
}
