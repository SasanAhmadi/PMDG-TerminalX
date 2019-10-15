using PMDGTerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDGTerminalX.NavAid
{
    public class Fix
    {
        public Fix(string name, GeoLocation location)
        {
            Name = name;
            Location = location;
            IsCorrelated = false;
        }
        public bool IsCorrelated { get; }
        public GeoLocation Location { get; set; }
        public string Name { get; set; }
        public string ParseFix()
        {
            return "FIX " + Name + " LATLON " + Location.ToDdString();
        }
    }
}
