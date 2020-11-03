using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAssociation
{
    class Moteur
    {
        private string Type;
        private string Puissance;
        public Moteur(string Type, string Puissance)
        {
            this.Type = Type;
            this.Puissance = Puissance;
        }
        public void Afficher()
        {
            Console.WriteLine("type: " + Type + " puissance: " + Puissance);
        }

    }
}
