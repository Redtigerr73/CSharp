using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureV2
{
    class Temperature
    {
        public double tempEnCel { get; set; }
        public double tempEnFahr { get; set; }
        public char unite { get; set; }

        public Temperature(double temp, char unite)
        {
            if (unite == 'C')
            tempEnCel = temp;
            if (unite == 'F')
            tempEnFahr = temp;
            this.unite = unite;
        }

        public double EnCel()
        {
            if (unite == 'F')
                return tempEnFahr = (tempEnCel - 32) * 5 / 9;
            else
                return tempEnCel;
        }

        public double EnFahr()
        {
            if (unite == 'C')
                return tempEnCel = tempEnFahr * 9 / 5 + 32;
            else
                return tempEnFahr;
        }

        public bool Chauffage()
        {
            if (EnCel() < 15)
                return true;
            else return false;
        }


      

    }
}
