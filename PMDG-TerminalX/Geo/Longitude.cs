using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    internal class Longitude : GeoPointBase
    {
        public Longitude() { }

        public Longitude(decimal location) : base(location) { }

        public EasthWest EWHemisphere => _decimalValue < 0 ? EasthWest.West : EasthWest.East;

        public override string ToDmsString()
        {
            return base.ToDmsString() + EWHemisphere.ShortRepresentation();
        }

        public override string ToDdString()
        {
            return EWHemisphere.ShortRepresentation() + " " + base.ToDdString();
        }
    }
}
