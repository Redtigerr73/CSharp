﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCelciusEtFarenheit
{
    class Temperature
    {
        private double _temp;
        private char _unite;
        private bool _allumer;


        public Temperature(double temp, char unite)
        {
            _temp = temp;
            _unite = unite;
        }

        /// <summary>
        /// Si besoin de modifier les valeurs par après dans le main
        /// </summary>
        /// <param name="value"></param>
        public void SetCel(double value)
        {
            _temp = value;
            _unite = 'C';
        }

        public void SetFahr(double value)
        {
            _temp = value;
            _unite = 'F';

        }

        public double EnCel()
        {
            if (_unite == 'C')
                return _temp;
            else if (_unite == 'F')
                return Math.Round( ((_temp - 32) * (5.0 / 9)) ,2);
            else return _temp;
        }

        public double EnFahr()
        {
            if (_unite == 'F')
                return _temp;
            else if (_unite == 'C')
                return Math.Round ( ((_temp * (9.0 / 5)) + 32),2);
            else return _temp;
        }

        public bool Chauffage()
        {
            if (EnCel() < 15)
                _allumer = true;
            else _allumer = false;
            return _allumer;
        }

        public void Afficher()
        {
            Console.WriteLine($"Il faut allumer le chauffage? : {_allumer}");
        }
    }
}
