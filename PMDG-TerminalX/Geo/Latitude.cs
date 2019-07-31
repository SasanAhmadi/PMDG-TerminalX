using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    public class Latitude : GeoPointBase
    {
        public Latitude()
        {
            base.IdentifyHemisphereEvent += Latitude_IdentifyHemisphereEvent;
        }

        private void Latitude_IdentifyHemisphereEvent(object sender, decimal e)
        {
            if (e < 0)
                NSHemisphere = NorthSouth.South;
            else
                NSHemisphere = NorthSouth.North;
        }

        public NorthSouth NSHemisphere { get; private set; }
        public override string ToString()
        {
            return base.ToString() + (_decimalValue < 0 ? "S" : "N");
        }
    }
}
