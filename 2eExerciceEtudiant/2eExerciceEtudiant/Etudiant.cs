using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2eExerciceEtudiant
{
    public class Etudiant
    {
        public string nom;
        public double francais;
        public double anglais;
        public double neerlandais;
        public double arabe;
        public double moyenne;
        public string resultat;

        public Etudiant(string nom, double francais, double anglais, double neerlandais, double arabe)
        {
            this.nom = nom;
            this.francais = francais;
            this.anglais = anglais;
            this.neerlandais = neerlandais;
            this.arabe = arabe;
        }

        /// <summary>
        /// Fonction qui calcule la moyenne
        /// </summary>
        /// <param name="francais">Note sur 20 de l'examen de français</param>
        /// <param name="anglais"></param>
        /// <param name="neerlandais"></param>
        /// <param name="arabe"></param>
        public void Moyenne()
        {
            moyenne = (francais + anglais + neerlandais + arabe) / 4;
        }

        public void Resultat()
        {
            if (moyenne < 10)
                resultat = "echec";
            else
                resultat = "reussite";
        }

        public void Afficher()
        {
            Console.WriteLine($"{nom}, suite aux passages de vos 4 examens vous êtes en {resultat}");
        }

        
    }
}
