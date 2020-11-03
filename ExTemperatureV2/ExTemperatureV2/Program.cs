using System;

namespace ExTemperatureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature(40, 'C');
            Console.WriteLine(temp);
            Console.WriteLine($"La temperature est de {temp.EnCel()} il faut ouvrir le chauffage est : {temp.Chauffage()}");
            temp.temp = 14;
            Console.WriteLine($"La temperature est de {temp.EnCel()} il faut ouvrir le chauffage est : {temp.Chauffage()}");


            Sonde sonde = new Sonde(-400, 'C');
            sonde.Allumer();

            Console.ReadLine();
        }
    }
}
