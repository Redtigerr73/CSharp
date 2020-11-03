using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Moteur mot1 = new Moteur("Diesel", "95");
            Voiture Twingo = new Voiture("Twingo", "Essence", "55");
            Voiture Astra = new Voiture("Astra", mot1);
            Twingo.Afficher();
            Astra.Afficher();
            Commune Woluwe=new Commune();

            Personne jean = new Personne("jean", "jean", 25, "jaipasdadresse", null, null);
            Personne jeanne = new Personne("jeanne", "jeanne", 25, "jaipasdadresse2", null, null);
            Console.WriteLine("On va les marier");
            Woluwe.Marier(jean, jeanne);
            Console.WriteLine("On va les divorcer");
            Woluwe.Divorcer(jean, jeanne);
            
        }
    }
}
