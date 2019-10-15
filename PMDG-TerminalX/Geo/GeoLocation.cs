using PMDGTerminalX.Common;
using System;
using System.Text.RegularExpressions;

namespace PMDGTerminalX.Geo
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

        public GeoLocation(string geoString, GeoStringFormat stringFormat)
        {
            switch (stringFormat)
            {
                case GeoStringFormat.DMS:
                    throw new NotImplementedException("The constructor for DMS has not yet been implemented");
                case GeoStringFormat.DD:
                    //N 37 37.169167 W 122 22.433666
                    Regex pattern = new Regex(@"(?<latitude>\w+ \d+ (\d+(\.\d+)?)) (?<longitude>\w+ \d+ (\d+(\.\d+)?))");
                    Match match = pattern.Match(geoString);

                    Latitude = new Latitude(match.Groups["latitude"].Value, stringFormat);
                    Longitude = new Longitude(match.Groups["longitude"].Value, stringFormat);
                    break;
            }
            //Latitude = new Latitude(latitude);
            //Longitude = new Longitude(longitude);
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
