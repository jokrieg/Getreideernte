namespace ClassLibrary1
{
    public class Silo
    {
        private int aktuelleLadung;
        private int KAPAZITAET; 

        public Silo(int kapazitaet)
        {
            KAPAZITAET = kapazitaet;
            aktuelleLadung = 0;
        }

        public int getAktuelleLadung()
        {
            return aktuelleLadung;
        }

        public void addLadung(int ladung)
        {
            if (hatNochKapazitaet(ladung)) aktuelleLadung += ladung;
            else throw new OverflowException("Tank ist voll");
        }

        public bool hatNochKapazitaet(int ladung)
        {
            return aktuelleLadung + ladung <= KAPAZITAET;
        }

        public void leeren()
        {
            aktuelleLadung = 0;
        }
    }
}