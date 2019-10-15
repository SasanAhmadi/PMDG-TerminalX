using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMDGTerminalX.NavAid
{
    public class Airport
    {
        public Airport()
        {
            Fixes = new Dictionary<string, Fix>();
            Runways = new Dictionary<string, Runway>();
            Sids = new List<Sid>();
            Stars = new List<Star>();
            Approaches = new List<Approach>();
            Gates = new List<Gate>();
        }
        public string Description { get; set; }

        public Dictionary<string, Fix> Fixes { get; set; }
        public Dictionary<string, Runway> Runways { get; set; }
        public List<Sid> Sids { get; set; }
        public List<Star> Stars { get; set; }
        public List<Approach> Approaches { get; set; }
        public List<Gate> Gates { get; set; }

        public string ParseFixes()
        {
            var query = from f in Fixes
                        where f.Value.IsCorrelated == false
                        select f.Value.ParseFix();
            return "FIXES\n" + query.Aggregate((p, c) => p + "\n" + c) + "\nENDFIXES";
                         
        }
    }
}
