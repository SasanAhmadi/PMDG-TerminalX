using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.NavAid
{
    class Airport
    {
        public string Description { get; set; }

        public List<Fix> Fixes { get; set; }
        public List<Waypoint> Waypoints { get; set; }
        public List<Runway> Runways { get; set; }
        public List<Sid> Sids { get; set; }
        public List<Star> Star { get; set; }
        public List<Approach> Approached { get; set; }
        public List<Gate> Gates { get; set; }
    }
}
