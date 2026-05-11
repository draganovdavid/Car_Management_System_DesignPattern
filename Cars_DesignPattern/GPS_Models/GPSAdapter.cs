using Cars_DesignPattern.Interfaces;

namespace Cars_DesignPattern.GPS_Models
{
    public class GPSAdapter : IGPS
    {
        private OldGPS oldGPS;

        public GPSAdapter(OldGPS oldGPS)
        {
            this.oldGPS = oldGPS;
        }

        public void Navigate()
        {
            oldGPS.OldNavigate();
        }
    }
}