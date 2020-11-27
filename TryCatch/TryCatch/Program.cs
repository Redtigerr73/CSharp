using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test();
                Test2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        static void Test()
        {
            Console.WriteLine("Introduire un mot SVP");
            string mot = Console.ReadLine();
            Console.WriteLine($"La 10ieme lettre de {mot} est {mot[9]}");
        }
    }
}
