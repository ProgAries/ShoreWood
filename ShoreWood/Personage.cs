using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonster
{
    class Personage
    {
        #region Field
        
        private int _end;
        private int _for;
        private int _pvMax;
        private int _pv;
        
        #endregion
        
        #region Constructor
        public Personage()
        {
            DeAleatoire de = new DeAleatoire();

            End = de.DeAle();
            For = de.DeAle();
        }
        #endregion

        #region Proprery // Caractéristique
        public int End
        {
            get { return _end; }
            set { _end = value; }
        }


        public int For
        {
            get { return _for; }
            set { _for = value; }
        }


        public int PvMax
        {
            get { return _pvMax; }
            set { _pvMax = value; }
        }


        public int Pv
        {
            get { return _pv; }
            set { _pv = value; }
        }

        #endregion


        #region Methods

        public void Frappe(Personage ennemis)
        {
            DeAleatoire de4 = new DeAleatoire();
            int frp = de4.DeAle4() + Mod(For);
            ennemis.Pv -= frp;
        }

        public bool Mort()
        {
            if (Pv <= 0)
            {
                return true;
            }
            return false;
            
        }

        public int Mod(int v)
        {
            if (v < 5)
            {
                return  -1;
            }
            else if (v < 10)
            {
                return 0;
            }
            else if (v < 15)
            {
                return  1;
            }
            else
            {
                return 2;
            }
        }
        

        #endregion
    }
}
