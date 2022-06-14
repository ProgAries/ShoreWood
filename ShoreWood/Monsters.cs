using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Monsters : Personage
    {
        public Monsters()
        {
            Pv = End + Mod(End);
            PvMax = Pv;
        }

        private int _or;

        public int Or
        {
            get { return _or; }
            set { _or = value; }
        }

        private int _cuir;

        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        
        
    }
}
