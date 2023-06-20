using ClassLibrary1;

namespace Getreideernte
{
    public class Ernte
    {
        static void Main(string[] args)
        {
            Silo meinSilo = new Silo(10000);
            Maehdrescher meinMaehdrescher = new Maehdrescher(0, 300, true, 0);
            meinMaehdrescher.ernteBisVoll();
            meinMaehdrescher.fuelleSilo(meinSilo);
            meinSilo.leeren();
        }
    }
}