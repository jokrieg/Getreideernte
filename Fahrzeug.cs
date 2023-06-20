using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Fahrzeug
    {
        protected int betriebsstunden;
        protected int ps;
        protected bool funktionsfaehig;

        public Fahrzeug(int betriebsstunden, int ps, bool funktionsfaehig)
        {
            this.betriebsstunden = betriebsstunden;
            this.ps = ps;
            this.funktionsfaehig = funktionsfaehig;
        }
    }
}
