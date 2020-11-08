using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneCommuneRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("VW", "Golf");
            Personne p1 = new Personne("Reichmann", "Jeanluc", "25/04/1980");
            Personne p2 = new Personne("Abou", "Jeanette", "25/04/1976");
            Personne p3 = new Personne("Jojo", "LaBricole", "25/08/1998", v1);
            Commune woluwe = new Commune();
            p1.AcheterVoiture(p3);
            p2.AcheterVoiture(p3);
            p2.AcheterVoiture(p1);
            woluwe.Marier(p1, p2);
            woluwe.Marier(p3, p1);
            woluwe.Divorcer(p3, p1);

        }
    }
}
