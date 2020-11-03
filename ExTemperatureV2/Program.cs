using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature(40, 'C');
            Console.WriteLine(temp);
            Console.WriteLine($"La temperature est de {temp.tempEnCel} il faut ouvrir le chauffage est : {temp.Chauffage()}");
            temp.tempEnCel = 14;
            Console.WriteLine($"La temperature est de {temp.tempEnCel} il faut ouvrir le chauffage est : {temp.Chauffage()}");

        }
    }
}
