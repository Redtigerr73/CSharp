using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCelciusEtFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature valeur = new Temperature(15, 'C');
            valeur.Chauffage();
            valeur.Afficher();

            Temperature Temp = new Temperature(19.0, 'C');

            Console.WriteLine("Il fait " + Temp.EnCel() + "°C");
            Console.WriteLine("On pourrait également dire qu'il fait " + Temp.EnFahr() + "°F");
            Console.WriteLine("Ce n'est pas parce qu'on vient de lire la température en Fahrenheit que la température a changé: il fait toujours " + Temp.EnCel() + "°C");
            Console.WriteLine("Et même si on la lit plusieurs fois en Celsiusx: il fait toujours " + Temp.EnCel() + "°C");

            Temp = new Temperature(30.0, 'F');
            Console.WriteLine("Il fait maintenant " + Temp.EnFahr() + "°F, ou encore  " + Temp.EnCel() + "°C ");
            if (Temp.Chauffage()) Console.WriteLine("Allumez le chauffage");
            else Console.WriteLine("Il fait bon");

            // Sonde spatiale
            valeur.SetTemp(-271);
            valeur.SetUnit('C');

            while (valeur.EnCel() < -50)
            {

                Console.WriteLine($"Il fait {valeur.EnCel()} °C ");
                Console.WriteLine("Augmentation de 25°F");
                valeur.SetTemp(valeur.EnFahr()+25);
                valeur.SetUnit('F');
            }

            Console.WriteLine($"La valeur en Celcius est de {valeur.EnCel()}");
            
        }
    }
}
