using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Heroes : Personage
    {

        private Dictionary<string, int> _sac = new() { { "cuir", 0 }, { "or", 0 } };

        public Dictionary<string, int> Sac
        {
            get { return _sac; }
            set { _sac = value; }
        }

        public void Voler(Monsters monters)
        {
            Sac["cuir"] += monters.Cuir;
            monters.Cuir = 0;
            Sac["or"] += monters.Or;
            monters.Or = 0;
        }
    }
}
