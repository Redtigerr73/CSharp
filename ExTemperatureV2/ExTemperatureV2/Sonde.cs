using System;

namespace ExTemperatureV2
{
    class Sonde
    {
        public Temperature Temperature { get; set; }
        //Temperature sondeA = new Temperature(-271, 'C');

        public Sonde(double temp, char unite)
        {
            Temperature = new Temperature(temp, unite);
        }

        public void Allumer()
        {
            while (Temperature.EnCel() < -50)
            {
                Temperature.temp = Temperature.EnFahr() + 25;
                Temperature.temp = Temperature.EnCel();
                Console.WriteLine(Temperature.temp);
            }
        }
    }
}
