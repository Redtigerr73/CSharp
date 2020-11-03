﻿namespace ExTemperatureV2
{
    class Temperature
    {
        public double temp { get; set; }
        public char unite { get; set; }

        public Temperature(double temp, char unite)
        {
            this.temp = temp;
            this.unite = unite;
        }

        public double EnCel()
        {
            if (unite == 'F')
            {
                unite = 'C';
                return (temp - 32) * 5 / 9;
            }
            else
                return temp;
        }

        public double EnFahr()
        {
            if (unite == 'C')
            {
                unite = 'F';
                return temp * 9 / 5 + 32;
            }
            else
                return temp;
        }

        public bool Chauffage()
        {
            if (EnCel() < 15)
                return true;
            else return false;
        }




    }
}
