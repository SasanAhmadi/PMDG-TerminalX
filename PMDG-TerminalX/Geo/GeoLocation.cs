using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    public class GeoLocation
    {
        public GeoLocation()
        {
            Latitude = new Latitude();
            Longitude = new Longitude();
        }

        public GeoLocation(decimal latitude, decimal longitude)
        {
            Latitude = new Latitude(latitude);
            Longitude = new Longitude(longitude);
        }

        public Latitude Latitude { get; set; }

        public Longitude Longitude { get; set; }

        public override string ToString()
        {
            return Latitude.ToString() + " " + Longitude.ToString();
        }
    }
}
