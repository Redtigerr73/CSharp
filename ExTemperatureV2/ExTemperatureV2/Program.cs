using System;
namespace ExTemperatureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temperature temp = new Temperature(40, 'C');
            Temperature nouvelleTemp = new Temperature();
            
            Console.WriteLine($"La temperature est de {nouvelleTemp.EnCel()} il faut ouvrir le chauffage est :{nouvelleTemp.Chauffage()}");
            nouvelleTemp.temp = 14;
            Console.WriteLine($"La temperature est de {nouvelleTemp.EnCel()} il faut ouvrir le chauffage est : {nouvelleTemp.Chauffage()}");


            //Sonde sonde = new Sonde(-400, 'C');
            //sonde.Allumer();

            //Console.ReadLine();


        }
    }
}
