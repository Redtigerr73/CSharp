using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    class César
    {
        private char _clef;
        private string _messageChiffre;
        

        public César(char clef)
        {
            _clef = clef;
        }

        public void Chiffrer(string messageADechiffrer)
        {
            for (int i = 0; i < messageADechiffrer.Length; i++)
            {
                int asci = (int)messageADechiffrer[i]-_clef;

                _messageChiffre[i] = (char)asci;



            }
        }


    }
}
