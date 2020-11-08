namespace ExCompteBancaireRev
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compte = new CompteBancaire("BE3100147156", 1000, 1000);
            compte.Retirer(2500);
            compte.Verser(500);
            compte.Retirer(2500);
            compte.Retirer(1);
            compte.Afficher(compte);
        }
    }
}
