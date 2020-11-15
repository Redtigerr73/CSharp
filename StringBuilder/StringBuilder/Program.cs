using System;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {

            Replace rpl = new Replace();
            string txt = "LENOVO";
            Console.WriteLine(txt);
            string newrpl = rpl.Remplacer(txt);
            Console.WriteLine("Après changement    " + newrpl);

        }
    }
}
