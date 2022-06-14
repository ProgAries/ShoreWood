using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Loup : Monsters
    {
        public Loup()
        {
            DeAleatoire de = new DeAleatoire();
            Cuir = de.DeAle4(); 
        }
    }
}
