using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseStatiqueLireString
{
    static class Saisie
    {
        public static String LireString(String msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static int LireEntier(String msg)
        {
            bool conversionOk;
            int result;

            do
            {

                conversionOk = int.TryParse(LireString(msg), out result);

            }
            while (conversionOk == false);

            return int.Parse(LireString(msg));
        }

        public static double LireDouble(String msg)
        {
            bool conversionOk;
            double result;

            do
            {

                conversionOk = double.TryParse((LireString(msg)), out result);
            }
            while (conversionOk == false);

            return result;
        }

        public static bool LireBoolean(String msg)
        {
            bool conversionOk;
            bool result;

            do
            {
                conversionOk = bool.TryParse( LireString(msg), out result);
            }

            while (conversionOk == false);

            return result;
        }

    }
    
}
