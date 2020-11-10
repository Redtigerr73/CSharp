namespace ExHeroRev
{
    class Arme
    {
        #region Champ

        private string _nomArme;
        private int _bonusArme;


        #endregion

        #region Propriétés

        public string NomArme
        {
            get { return _nomArme; }
            set { _nomArme = value; }
        }
        public int BonusArme
        {
            get { return _bonusArme; }
            set { _bonusArme = value; }
        }

        #endregion

        #region Constructeur

        public Arme(string nomArme, int bonusArme)
        {
            NomArme = nomArme;
            BonusArme = bonusArme;
        }

        #endregion
    }
}
