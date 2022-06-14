using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    public class DeAleatoire
    {
       public int DeAle()
       {
            int rnd;
            int[] tbA = new int[4];

            for (int i = 0; i < 4; i++)
            {
                rnd = new Random().Next(1, 7);
                tbA[i] = rnd;
            }
            int min = tbA.Min();
            return tbA.Sum()- min;
       }

        public int DeAle6()
        {
            int rnd;
            rnd = new Random().Next(1, 7);
            return rnd;
        }

        public int DeAle4()
        {
            int rnd;
            rnd = new Random().Next(1, 5);
            return rnd;
        }

        public int DeAle3()
        {
            int rnd;
            rnd = new Random().Next(1, 4);
            return rnd;
        }

        public int DeAle20()
        {
            int rnd;
            rnd = new Random().Next(10, 26);
            return rnd;
        }

    }
}
