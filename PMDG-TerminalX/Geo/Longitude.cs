using PMDGTerminalX.Base;
using PMDGTerminalX.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PMDGTerminalX.Geo
{
    public class Longitude : GeoPointBase
    {
        public Longitude() { }

        public Longitude(decimal location) : base(location) { }

        public Longitude(string location, GeoStringFormat stringFormat)
        {
            switch (stringFormat)
            {
                case GeoStringFormat.DMS:
                    throw new NotImplementedException("The constructor for DMS has not yet been implemented");
                case GeoStringFormat.DD:
                    //N 35 16.529306
                    Regex pattern = new Regex(@"(?<hemisphere>\w+) (?<degree>\d+) (?<second>\d+(\.\d+)?)");
                    Match match = pattern.Match(location);
                    int degree = int.Parse(match.Groups["degree"].Value);
                    decimal second = decimal.Parse(match.Groups["second"].Value);
                    EasthWest easthWest;
                    switch (match.Groups["hemisphere"].Value)
                    {
                        case "E":
                            easthWest = EasthWest.East;
                            break;
                        default:
                            easthWest = EasthWest.West;
                            break;
                    }

                    SetDdPoint(degree, second, easthWest);
                    break;
            }   
        }

        public EasthWest EWHemisphere => _decimalValue < 0 ? EasthWest.West : EasthWest.East;

        public override string ToDmsString()
        {
            return base.ToDmsString() + EWHemisphere.ShortRepresentation();
        }

        public override string ToDdString()
        {
            return EWHemisphere.ShortRepresentation() + " " + base.ToDdString();
        }

        public void SetDmsPoint(int degree, int minute, decimal second, EasthWest easthWest)
        {
            base.DMS = ((easthWest == EasthWest.East ? 1 : -1) * degree, minute, second);
        }

        public void SetDdPoint(int degree, decimal second, EasthWest easthWest)
        {
            base.DD = ((easthWest == EasthWest.East ? 1 : -1) * degree, second);
        }
    }
}
