using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTemperatureRevision
{
    class Sonde
    {
        private Temperature _tempSonde;

        public Sonde(Temperature tempSonde)
        {
            _tempSonde = tempSonde;
        }

        public bool ActiverChauffage()
        {
            //if (_tempSonde.GetUnite() == 'C')
            //{
            //    _tempSonde.SetTemp(_tempSonde.EnFahr(), 'F');
            //}
            while (_tempSonde.EnCel() < -50)
            {
                _tempSonde.SetTemp(_tempSonde.EnFahr() + 15.0, 'F');
                _tempSonde.Afficher();
            }
            return false;
        }
    }
}
