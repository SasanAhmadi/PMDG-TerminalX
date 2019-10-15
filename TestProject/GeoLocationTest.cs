using PMDGTerminalX.Common;
using PMDGTerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TerminalXTest
{
    public class GeoLocationTest
    {
        [Fact]
        public void CheckGeoLocationDmsStringOutput()
        {
            var geoLocation = new GeoLocation(35.410179m, 51.155586m);
            Assert.Equal("35°24'36.6\"N 51°09'20.1\"E", geoLocation.ToDmsString());
        }

        [Fact]
        public void CheckGeoLocationConstructorWithDdStringPoint()
        {
            var geoLocation = new GeoLocation("N 37 37.169167 W 122 22.433666", GeoStringFormat.DD);
            Assert.Equal("N 37 37.169167 W 122 22.433666", geoLocation.ToDdString());
            Assert.Equal("37°37'10.1\"N 122°22'26.0\"W", geoLocation.ToDmsString());
            Assert.Equal(37.619486M, geoLocation.Latitude.DecimalValue);
            Assert.Equal(-122.373894M, geoLocation.Longitude.DecimalValue); 
        }
    }
}
