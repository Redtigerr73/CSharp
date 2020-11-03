using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureRevision
{
    class Temperature
    {
        private double _temp;
        private char _unite;

        public Temperature(double temp, char unite)
        {
            _temp = temp;
            _unite = unite;
        }

        public void SetTemp(double temp, char unite)
        {
            if (unite == 'C')
                _temp = temp;
            else
            {
                _temp = ((temp - 32) * 5 / 9) ;
                _unite = unite;
            }
        }

        public void SetUnite(char unite)
        {
            _unite = unite;
        }

        public char GetUnite()
        {
            return _unite;
        }

        public double GetTemp(double temperature)
        {
            return temperature;
        }

        public double EnCel()
        {
            if (_unite == 'C')
                return _temp;
            else
            {
                return ((_temp - 32) * 5 / 9);
            }
        }

        public double EnFahr()
        {
            if (_unite == 'F')
                return _temp;
            else
            {
                return ((_temp * 9) / (5 + 32));
            }

        }

        public bool Chauffage()
        {
            if (EnCel() < 15)
                return true;
            else return false;
        }

        public void Afficher()
        {
            Console.WriteLine($"La température est de {_temp} {_unite}");
        }

    }
}
