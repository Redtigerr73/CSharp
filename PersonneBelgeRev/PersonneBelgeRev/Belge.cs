using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeRev
{
    class Belge : Personne
    {
        # region Champ
        private string _communaute;

        
        #endregion

        #region Propriété
        public string Communaute
        {
            get { return _communaute; }
            set { _communaute = value; }
        }
        #endregion

        #region Constructeur
        public Belge(string Nom, string Prenom, string com) : base(Nom, Prenom)
        {
            Communaute = com;
        }
        #endregion

        #region Méthode
        public new void Afficher()
        {
            Console.Write($"Nom : {Nom} et Prénom : { Prenom}");
            Console.Write($" + {Communaute}\n");
        }
        #endregion

    }
}
