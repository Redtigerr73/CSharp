using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAssociation
{
    class Commune
    {
        
        public void Marier(Personne a, Personne b)
        {
            if (a.GetConjoint() == null && b.GetConjoint() == null )
            {
                a.SetConjoint(b);
                b.SetConjoint(a);

                
                    Console.WriteLine("Vous êtes mariés ! Félicitations ! ");
            }
        }

        public void Divorcer(Personne a, Personne b)
        {
            if ( a.GetConjoint() == b && b.GetConjoint() == a )
            {
                a.SetConjoint(null);
                b.SetConjoint(null);
                Console.WriteLine("Felicitations, vous êtes libres !");
            }

            else Console.WriteLine( "Mais vous êtes même pas mariés ensemble !? " );
        }
    }
}
