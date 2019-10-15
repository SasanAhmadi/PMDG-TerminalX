using PMDGTerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMDGTerminalX.Interface
{
    public interface IGeoLocationCollection<in T> where T : GeoLocation
    {
        void Add(T item);
        
    }
}
