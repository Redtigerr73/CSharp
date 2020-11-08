namespace JeuRoleHero
{
    class Arme
    {
        private string nomArme;
        private int Degat;

        public Arme(string nomArme, int degat)
        {
            this.nomArme = nomArme;
            Degat = degat;
        }

        public int GetDegat()
        {
            return Degat;
        }
    }
}
