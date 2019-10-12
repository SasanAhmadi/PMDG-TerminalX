using PMDG_TerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.NavAid
{
    public class Fix
    {
        public Fix(string name, GeoLocation location)
        {
            Name = name;
            Location = location;
        }
        public GeoLocation Location { get; set; }
        public string Name { get; set; }
        public string ParseFix()
        {
            return "FIX " + Name + " LATLON " + Location.ToDdString();
        }
    }
}
