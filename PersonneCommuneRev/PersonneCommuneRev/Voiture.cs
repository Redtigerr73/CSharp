using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneCommuneRev
{
    class Voiture
    {
        private string _marque;
        private string _model;


        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Voiture(string marque, string model)
        {
            Marque = marque;
            Model = model;
        }



    }
}
