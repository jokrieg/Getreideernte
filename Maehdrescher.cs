using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Maehdrescher : Fahrzeug 
    {
        private int getreideTankInhalt;
        public Maehdrescher(int betriebsstunden, int ps, bool funktionsfaehig, int getreideTankInhalt) : base(betriebsstunden, ps, funktionsfaehig)
        {
            this.getreideTankInhalt = getreideTankInhalt;
        }

        public void ernteBisVoll()
        {
            getreideTankInhalt = 3500;
        }

        public void fuelleSilo(Silo silo)
        {
            while (silo.hatNochKapazitaet(100) && getreideTankInhalt >= 0) 
            {
                silo.addLadung(100);
            }
        }
    }
}
