using System;

namespace SaisieRev
{
    static class Saisie
    {
        //private int i;
        //public int I
        //{
        //    get { return i; }
        //    set { i = value; }
        //}

        //private string s;
        //public string S
        //{
        //    get { return s; }
        //    set { s = value; }
        //}

        //private bool b;
        //public bool B
        //{
        //    get { return b; }
        //    set { b = value; }
        //}
        public static string LireString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static int LireInt(string msg)
        {
            bool valide = false;
            int i;
            do
            {
                Console.WriteLine(msg);
                valide = int.TryParse(Console.ReadLine(), out i);
            }
            while (valide == false);
            return i;
        }



        public static bool LireBool(string msg)
        {
            bool valide = false;
            bool b;
            do
            {
                Console.WriteLine(msg);
                valide = bool.TryParse(Console.ReadLine(), out b);
            }
            while (valide == false);
            return b;
        }



    }
}
