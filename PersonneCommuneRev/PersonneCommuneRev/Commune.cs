using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersonneCommuneRev
{
    class Commune
    {
        private Personne _p1;
        private Personne _p2;



        public void Marier(Personne _p1, Personne _p2 ) //possibilité de ne prendre en paramètre que 1 classe objet?
        {
            if (_p1 != null && _p2 != null)
            {
                Console.WriteLine("Veuillez d'abord divorcer avant de vous remarier");
            }
            else 
            {
                _p1.Conjoint = _p2;
                _p2.Conjoint = _p1;
                Console.WriteLine($"Félicitations pour votre mariage {_p1.Prenom} et {_p2.Prenom}");
            }
        }

        public void Divorcer(Personne _p1, Personne _p2)
        {
            if (_p1.Conjoint != _p2 && _p2.Conjoint != _p1)
            {
                Console.WriteLine($"{_p1.Prenom} et {_p2.Prenom} vous n'étiez pas marié ensemble");
            }
            else if (_p1.Conjoint == null && _p2.Conjoint == null)
            {
                Console.WriteLine("C'est qui qui est déjà célibataire ? Impossible de divorcer");
            }
            else
            {
                _p1.Conjoint = null;
                _p2.Conjoint = null;
                Console.WriteLine($"{_p1.Prenom} et {_p2.Prenom} votre divorce a bien été prononcé");
            }
        }
    }
}
