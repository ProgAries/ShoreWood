using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Nain : Heroes
    {
        public Nain()
        {
            End = End + 2;
            Pv = End + Mod(End);
            PvMax = Pv;
            
        }
    }
}
