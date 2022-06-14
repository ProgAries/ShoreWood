using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Dragon : Monsters
    {
        public Dragon()
        {
            End += 1;
            DeAleatoire de = new DeAleatoire();
            Cuir = de.DeAle4();
            Or = de.DeAle6();
        }
    }
}
