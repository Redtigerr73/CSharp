using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAssociation
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private string addresse;
        private Voiture voiturePrive;
        public Personne conjoint;

        public Personne(string nom, string prenom, int age, string addresse, Personne conjoint, Voiture voiturePrive)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.addresse = addresse;
            this.conjoint = conjoint;
            this.voiturePrive = voiturePrive;
        }

        
        public void SetVoiturePrive(Voiture voiturePrive)
        {
            this.voiturePrive = voiturePrive;
        }

        public void VendreVoiture(Personne acheteur)
        {
            if (this.voiturePrive != null)
            {
                acheteur.voiturePrive = this.voiturePrive;
                this.voiturePrive = null;
            }
        }

        public Personne GetConjoint()
        {
            return conjoint;
        }

        public void SetConjoint(Personne marie)
        {
            this.conjoint = marie;
        }



    }
}
