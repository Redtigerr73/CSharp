using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryCatch2.Exceptions;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb, i, j;
            int[] tabNb = new int[5];
            Console.WriteLine("Merci d'introduire 5 nombres");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Nombre" + k);
                nb = int.Parse(Console.ReadLine());
                tabNb[k] = nb;
            }
            Console.WriteLine("Introduire 2 valeurs i et j");
            Console.WriteLine("Introduire i");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduire j");
            j = int.Parse(Console.ReadLine());


            try
            {
                if (i == 0 || j == 0)
                    throw new IndexZeroException("");

                Console.WriteLine(tabNb[i]/tabNb[j]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
