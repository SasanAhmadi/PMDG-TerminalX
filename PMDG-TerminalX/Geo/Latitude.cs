using PMDG_TerminalX.Base;
using PMDG_TerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Geo
{
    internal class Latitude : GeoPointBase
    {
        public Latitude() { }

        public Latitude(decimal location) : base(location) { }

        public NorthSouth NSHemisphere => _decimalValue < 0 ? NorthSouth.South : NorthSouth.North;

        
        public override string ToDmsString()
        {
            return base.ToDmsString() + NSHemisphere.ShortRepresentation();
        }

        public override string ToDdString()
        {
            return NSHemisphere.ShortRepresentation() + " " + base.ToDdString();
        }

        public void SetDmsPoint(int degree, int minute, decimal second, NorthSouth northSouth)
        {
            base.DMS = ((northSouth == NorthSouth.North?1:-1) * degree, minute, second);
        }

        public void SetDdPoint(int degree, decimal second, NorthSouth northSouth)
        {
            base.DD = ((northSouth == NorthSouth.North ? 1 : -1) * degree, second);
        }
    }
}
