using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoleHero
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Bob = new Hero("Bob", 50);
            Hero Marley = new Hero("Marley", 50);
            //Arene ring = new Arene(Bob,Marley);
            Mage Gandalf = new Mage("Gandalf", 50, 6);
            Gandalf.Duel(Bob);

            

            
        }
    }
}
