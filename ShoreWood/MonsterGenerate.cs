using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster 
{
    class MonsterGenerate 
    {
        public static List<string> GenerateMonster(Monsters[] personages)
        {
            DeAleatoire de = new DeAleatoire();
            List<string> monster = new List<string>();
            for (int i = 0; i < personages.Length; i++)
            {
                int rng = de.DeAle4();

                switch (rng)
                {
                    case 1:
                    case 4:
                        personages[i] = new Loup();
                        break;
                    case 2:
                        personages[i] = new Orque();
                        break;
                    case 3:
                        personages[i] = new Dragon();
                        break;
                }
                monster.Add((i + 1) + "° " + personages[i].GetType().Name);
            }
            return monster;
        }
    }
}
