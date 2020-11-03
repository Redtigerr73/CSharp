using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DéRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            De testDe = new De();
            
            testDe.Lancer();
            testDe.Afficher();
            

            De testDe2 = new De();
            testDe2.Lancer();
            testDe2.Afficher();
        }
    }
}
