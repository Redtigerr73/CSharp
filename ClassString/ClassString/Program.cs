using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Merci d'introduire le texte en miniscule");
            //Majuscule txt = new Majuscule(Console.ReadLine());
            //txt.EnMajuscule();
            string txt1 = "   Hello     ";
            Espace space = new Espace(txt1);
            space.SupprimerEspace();
            Decouper mot = new Decouper("Je suis un très gentil homme");
            mot.DecoupeString();
            mot.Afficher();
        }
    }
}
