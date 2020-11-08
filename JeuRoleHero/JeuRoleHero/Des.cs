using System;

namespace JeuRoleHero
{

    class Des
    {
        public int Valeur;
        public int NbLancee;
        public Random rng = new Random();

        public Des(int nbLancee = 1, int valeur = 1)
        {
            Valeur = valeur;
            NbLancee = nbLancee;
        }


        public void Lancer()
        {
            Valeur = rng.Next(1, 7);
        }

        public int Lire()
        {
            return Valeur;
        }

        public void Afficher()
        {
            Console.WriteLine(Valeur);
        }






    }
}


