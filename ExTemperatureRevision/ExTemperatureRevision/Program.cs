using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature tempFusee = new Temperature(-42,'C');
            Console.WriteLine($"En Fahr = {tempFusee.EnFahr()}°F");
            Console.WriteLine($"Il faudra allumer le chauffage {tempFusee.Chauffage()}");

            tempFusee.SetTemp(200, 'F');
            Console.WriteLine($"En Cel = {tempFusee.EnCel()}°C");
            Console.WriteLine($"Il faudra allumer le chauffage {tempFusee.Chauffage()}");

            tempFusee.SetTemp(-271, 'C');
            Sonde SondeFusee = new Sonde(tempFusee);
            SondeFusee.ActiverChauffage();
            Console.WriteLine(tempFusee.EnCel());
            
        }
    }
}
