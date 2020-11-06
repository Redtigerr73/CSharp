using System;

namespace ExHeroRev
{
    class De
    {
        //static pour créer un seul objet aléatoire et donc on va pas créer 2 instances Rng en même temps.
        private static Random rng = new Random();
        private int valeurDé;

        //créer un constructeur pour ne pas avoir un état indéterminé (pour pas que ça crash)
        public De()
        {
            this.valeurDé = 1;
        }

        public int Lancer()
        {
            return valeurDé = rng.Next(1, 7);
        }

        public void Afficher()
        {
            Console.WriteLine($"La valeur du dé est : {Lancer()}");
        }

    }
}
