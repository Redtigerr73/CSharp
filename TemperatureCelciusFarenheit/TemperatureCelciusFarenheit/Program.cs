using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureCelciusFahrenheit;

namespace TemperatureCelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature(57, 'F');
            Console.WriteLine($"Faut-il allumer le chauffage? : {temp.Chauffage()}");
        }
    }
}
