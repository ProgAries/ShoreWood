using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Orque : Monsters
    {
        public Orque()
        {
            DeAleatoire de = new DeAleatoire();
            For += 1;
            Or = de.DeAle6();
        } 
    }
}
