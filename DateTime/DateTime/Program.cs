using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateHeure = (DateTime) DateTime.Now;
            Console.WriteLine(dateHeure);

            Console.WriteLine("Introduisez la date de naissance svp");
            DateTime ddn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(ddn.DayOfWeek);
            TimeSpan timeSpan = dateHeure - ddn;
             
            Console.WriteLine($"{timeSpan.Days} jours, {timeSpan.Hours} heures, {timeSpan.Minutes} minutes, {timeSpan.Seconds} secondes" );
            DateTime dateHeure2 = (DateTime)DateTime.Now;
            TimeSpan timeSpan2 = dateHeure2 - dateHeure;
            Console.WriteLine($"Il aura fallut {timeSpan2.Seconds} secondes et {timeSpan2.Milliseconds}  millisecondes");


        }
    }
}
