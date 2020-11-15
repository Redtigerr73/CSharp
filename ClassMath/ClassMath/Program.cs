using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMath
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                double nb = i;
                double test = Math.Round(Math.Pow(Math.Cos(nb), 2) + Math.Pow(Math.Sin(nb), 2));
                Console.WriteLine($"{Math.Pow(Math.Cos(nb), 2)} + {Math.Pow(Math.Sin(nb), 2)}");
                if (test != 1)
                    Console.WriteLine("Différent de 1 ! ");
                Console.WriteLine(" = "+test);
            }
            

        }
    }
}
