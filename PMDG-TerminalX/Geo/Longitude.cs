using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    public class Longitude : GeoPointBase
    {
        public EasthWest EWHemisphere => _decimalValue < 0 ? EasthWest.West : EasthWest.East;

        public override string ToString()
        {
            return base.ToString() + EWHemisphere.ShortRepresentation();
        }
    }
}
