using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    public class Longitude : GeoPointBase
    {
        public Longitude()
        {
            base.IdentifyHemisphereEvent += Longitude_IdentifyHemisphereEvent;
        }

        private void Longitude_IdentifyHemisphereEvent(object sender, decimal e)
        {
            if (e < 0)
                EWHemisphere = EasthWest.West;
            else
                EWHemisphere = EasthWest.East;
        }

        public EasthWest EWHemisphere { get; private set; }

        public override string ToString()
        {
            return base.ToString() + (_decimalValue < 0 ? "W" : "E");
        }
    }
}
