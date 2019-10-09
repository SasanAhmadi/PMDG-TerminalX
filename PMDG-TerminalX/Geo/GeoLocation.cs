using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    internal class GeoLocation
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

        public string ToDmsString()
        {
            return Latitude.ToDmsString() + " " + Longitude.ToDmsString();
        }

        public string ToDdString()
        {
            return Latitude.ToDdString() + " " + Longitude.ToDdString();
        }
    }
}
