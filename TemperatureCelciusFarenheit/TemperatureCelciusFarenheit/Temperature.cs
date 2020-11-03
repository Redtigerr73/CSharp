using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCelciusFahrenheit
{
    class Temperature
    {
        private double _temp;
        private char _unite;
        private bool _allumer;

        private Temperature(double temp, char unite)
        {
            _temp = temp;
            _unite = unite;
        }

        private double EnCel()
        {
            if (_unite == 'F')
                return ((_temp - 32) * (5 / 9));
            else return _temp;
        }

        private double EnFahr()
        {
            if (_unite == 'C')
                return ((_temp * (9 / 5)) + 32);
            else return _temp;   
        }

        public bool Chauffage()
        {
            EnCel();
            EnFahr();
            if (_unite == 'C')
            {
                if (_temp < 15)
                    _allumer = true;
            }

            else if (_unite == 'F')
            {
                if (_temp < 59)
                    _allumer = true;
            }
            else _allumer = false;
            return _allumer;
        }




    }
}
