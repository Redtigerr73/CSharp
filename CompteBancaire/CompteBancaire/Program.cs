using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte Momo = new Compte(12345, 1000, false);
            for (int i = 0; i < 5; i++)
            {
                Momo.Retrait(249);
            }
            

        }
    }
}
