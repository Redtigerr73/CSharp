using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneBelgeHeritage
{
    class Personne
    {
        protected string _nom;
        protected string _prenom;

        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom : {_nom} Prénom : {_prenom}");
        }
    }
}
