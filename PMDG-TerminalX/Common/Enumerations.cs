using System;
using System.Collections.Generic;
using System.Text;

namespace PMDGTerminalX.Common
{
    public enum NorthSouth
    {
        North = 0,
        South = 1
    }

    public enum EasthWest
    {
        East = 0,
        West = 1
    }

    public enum GeoStringFormat
    { 
        DMS = 0,
        DD  = 1
    }
    public static class EnumerationUtilities
    {
        public static string ShortRepresentation(this NorthSouth e)
        {
            switch (e)
            {
                case NorthSouth.North: return "N";
                default: return "S";
            }
        }

        public static string ShortRepresentation(this EasthWest e)
        {
            switch (e)
            {
                case EasthWest.East: return "E";
                default: return "W";
            }
        }
    }
}
