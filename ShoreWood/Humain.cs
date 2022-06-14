using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Humain : Heroes
    {
        public Humain()
        {
            Pv = End + Mod(End);
            PvMax = Pv;
        }
    }
}
