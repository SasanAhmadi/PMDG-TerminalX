using PMDG_TerminalX;
using PMDG_TerminalX.Geo;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoLocation location = new GeoLocation();
            location.Latitude.DecimalValue = 0.300861M;
            location.Longitude.DecimalValue = -79.816667M;

            Console.WriteLine(location.ToString());
        }
    }
}
