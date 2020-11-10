using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassString
{
    class Espace
    {
        public string _avecEspace { get; private set; }
        public string _sansEspace { get; private set; }

        public Espace(string avecEspace)
        {
            _avecEspace = avecEspace;
        }

        public void SupprimerEspace()
        {
            _sansEspace = _avecEspace.Trim();
            Console.WriteLine(_sansEspace);
        }

    }
}
