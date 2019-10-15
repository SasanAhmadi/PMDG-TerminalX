using PMDGTerminalX.Base;
using PMDGTerminalX.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace PMDGTerminalX.Geo
{
    public class Latitude : GeoPointBase
    {
        #region Constructors
        public Latitude() { }

        public Latitude(decimal location) : base(location) { }

        public Latitude(string location, GeoStringFormat stringFormat) 
        {
            switch (stringFormat)
            {
                case GeoStringFormat.DMS:
                    throw new NotImplementedException("The constructor for DMS has not yet been implemented");
                case GeoStringFormat.DD:
                    //N 35 16.529306
                    Regex pattern = new Regex(@"(?<hemisphere>\w+) (?<degree>\d+) (?<second>\d+(\.\d+)?)");
                    Match match = pattern.Match(location);
                    int degree = int.Parse(match.Groups["degree"].Value, CultureInfo.InvariantCulture);
                    decimal second = decimal.Parse(match.Groups["second"].Value, CultureInfo.InvariantCulture);
                    NorthSouth northSouth;
                    switch (match.Groups["hemisphere"].Value)
                    {
                        case "N":
                            northSouth = NorthSouth.North;
                            break;
                        default:
                            northSouth = NorthSouth.South;
                            break;
                    }

                    SetDdPoint(degree, second, northSouth);
                    break;
            }
        }
        #endregion


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
