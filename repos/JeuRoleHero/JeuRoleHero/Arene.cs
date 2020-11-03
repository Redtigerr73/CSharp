using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoleHero
{
    class Arene
    {
        private Hero _Bob;
        private Hero _Marley;

        public Arene(Hero bob, Hero marley)
        {
            _Bob = bob;
            _Marley = marley;

            _Bob.Duel(_Marley);
        }

        
    }
}
