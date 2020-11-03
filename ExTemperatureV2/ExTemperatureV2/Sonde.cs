using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureV2
{
    class Sonde
    {
        Temperature sondeA = new Temperature(-271, 'C');
        
        public bool TestChauffage()
        {
            if (sondeA.EnCel() < -50)
                return true;
            else return false;
        }

        public void Allumer()
        {
            while (TestChauffage())
                sondeA.tempEnCel = sondeA.EnFahr() + 25;
        }
    }
}
