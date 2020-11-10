using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    class Decouper
    {

        public string NonDecoupe { get; private set; }
        public string Decoupe { get; private set; }
        public string[] tabMot;

        public Decouper(string nonDecoupe)
        {
            NonDecoupe = nonDecoupe;
        }

        public void DecoupeString()
        {
            tabMot = NonDecoupe.Split(' ');
        }

        public void Afficher()
        {
            foreach (string i in tabMot)
            {
                Console.WriteLine(i);
            }
        }
    }
}
