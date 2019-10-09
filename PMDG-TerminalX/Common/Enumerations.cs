using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Common
{
    internal enum NorthSouth
    {
        North = 0,
        South = 1
    }

    internal enum EasthWest
    {
        East = 0,
        West = 1
    }

    internal static class EnumerationUtilities
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
