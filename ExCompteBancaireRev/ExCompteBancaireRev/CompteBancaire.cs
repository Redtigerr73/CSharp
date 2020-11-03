using System;

namespace ExCompteBancaireRev
{
    class CompteBancaire
    {
        private string _numCompte;
        public string NumCompte
        {
            get => _numCompte;
            private set => _numCompte = value;
        }

        private double _solde;
        public double Solde
        {
            get => _solde;
            private set => _solde = value;
        }

        private double _decouvertAutorise;
        public double DecouvertAutorise
        {
            get => _decouvertAutorise;
            private set => _decouvertAutorise = value;
        }

        public CompteBancaire(string numCompte, double solde, double decouvertAutorise)
        {
            _numCompte = numCompte;
            _solde = solde;
            _decouvertAutorise = decouvertAutorise;
        }

        public void Verser(double montant)
        {
            _solde += montant;
            Console.WriteLine($"Versement de {montant}, vous possédez un solde de {_solde}");
        }

        public void Retirer(double montant)
        {
            if (_solde - montant >= -(_decouvertAutorise))
            {
                _solde -= montant;
                Console.WriteLine($"Retrait de {montant} autorisé, attention vous êtes à {_solde}");
            }
            else
            {
                Console.WriteLine($"Retrait de {montant} interdit, il ne vous reste que {_solde}");
            }
        }

        public void Afficher(CompteBancaire compte)
        {
            Console.WriteLine($"Le compte : {_numCompte}");
            Console.WriteLine($"Le solde est : {_solde}");
            Console.WriteLine($"Le découvert autorisé est de : {_decouvertAutorise}");
        }

    }
}
