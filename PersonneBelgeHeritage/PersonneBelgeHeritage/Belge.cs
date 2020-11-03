using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeHeritage
{
    class Belge : Personne
    {
        private string _communauté;

        public Belge(string nom, string prenom, string communauté ) : base(nom, prenom)
        {
            _communauté = communauté;
        }

        public string GetCommunaute()
        {
            return _communauté;
        }

        public new void Afficher()
        {
            Console.WriteLine($"Nom : {_nom} Prénom : {_prenom} ({GetCommunaute()})"); 
        }

    }
}
