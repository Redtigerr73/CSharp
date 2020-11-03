using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class Compte
    {
        private int _numCompte;
        private double _montant;
        private Boolean _decouvertAutorise;

        public Compte(int numCompte, double montant, Boolean decouvertAutorise)
        {
            _numCompte = numCompte;
            _montant = montant;
            _decouvertAutorise = decouvertAutorise;
        }

        public Boolean Retrait(double valeur)
        {
            if (_decouvertAutorise == false)
            {
                if (_montant - valeur < 0)
                {
                    Console.WriteLine($"Il est impossible de retirer {valeur}, il ne reste que {_montant} sur votre compte");
                    return false;
                }
                else
                {
                    Console.WriteLine($"Il est possible de retirer {valeur}, il ne reste que maintenant {_montant - valeur} sur votre compte");
                    _montant -= valeur;
                    return true;
                }
            }
            else
            {
                if (_montant - valeur < 0)
                {
                    Console.WriteLine($"Il est possible de retirer {valeur}, il ne reste que {_montant - valeur} sur votre compte");
                    Console.WriteLine("Attention vous êtes à découvert ! ");
                    _montant -= valeur;
                    return true;
                }
                else
                {
                    Console.WriteLine($"Il est possible de retirer {valeur}, il ne reste que maintenant {_montant - valeur} sur votre compte");
                    _montant -= valeur;
                    return true;
                }
            }
        }

        public Boolean Verser(double valeur)
        {
            double temp = valeur;
            _montant += valeur;

            if (_montant > temp)
            {
                Console.WriteLine($"Le versement de {valeur} a bien été effectué sur vos {temp}, vous avez maintenant {_montant}");
                return true;
            }

            else
            {
                Console.WriteLine($"Le versement de {valeur} n'a pas été effectué sur vos {temp}, vous avez toujours {_montant}");
                return false;
            }
        }
    }
}
