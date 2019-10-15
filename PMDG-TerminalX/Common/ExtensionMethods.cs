using System;
using System.Collections.Generic;
using System.Text;

namespace PMDGTerminalX.Common
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Truncate decimal value to specified length specified
        /// </summary>
        /// <param name="value"></param>
        /// <param name="lenghtToKeep" descripttion="must be greater than 0 and less than or equal to 10"></param>
        /// <returns></returns>
        public static decimal TruncateDecimal(this decimal value, int lenghtToKeep)
        {
            double coefficient = Math.Pow(10, (double)lenghtToKeep);
            return Math.Truncate(value * (int)coefficient) / (int)coefficient;
        }
    }
}
