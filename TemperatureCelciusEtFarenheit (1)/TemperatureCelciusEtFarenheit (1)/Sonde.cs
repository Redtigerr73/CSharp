using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureCelciusEtFarenheit
{
    class Sonde
    {
        private Temperature TempSonde = new Temperature(-271.0, 'C');
        
        public void Activation()
        {

            while (TempSonde.EnCel() < -50)
            {
                Console.WriteLine($"Il fait {TempSonde.EnCel()} °C ");
                Console.WriteLine("Augmentation de 25°F");
                TempSonde.SetFahr((TempSonde.EnFahr() + 25));

            }
            Console.WriteLine($"Il fait { TempSonde.EnCel()} °C et donc { TempSonde.EnFahr()} °F Nous avons bien dépassé la limite de -50 ° C ");
        }
     
       }   
}
