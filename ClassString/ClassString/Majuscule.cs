using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    class Majuscule
    {
        #region Champ


        #endregion

        #region Propriété
        public string Min { get; private set; }
        public string Maj { get; private set; }
        #endregion

        #region Constructeur
        public Majuscule(string min)
        {
            Min = min;
        }
        #endregion

        #region Méthode
        public void EnMajuscule()
        {
            Maj = Min.ToUpper();
            Console.WriteLine(Maj);
        }
        #endregion


    }
}
