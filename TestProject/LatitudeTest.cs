using PMDGTerminalX.Common;
using PMDGTerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TerminalXTest
{
    public class LatitudeTest
    {   
        [Fact]
        public void AssignDecimalValueCheckForCorrectConversionToDmsAndDd()
        {
            var latitude = new Latitude();
            latitude.DecimalValue = 35.696972M;
            Assert.Equal((35, 41, 49.1M), latitude.DMS);
        }

        [Fact]
        public void AssignDecimalValueCheckForCorrectDmsRepresentation()
        {
            var latitude = new Latitude();
            latitude.DecimalValue = 35.696972M;
            Assert.Equal("35°41'49.1\"N", latitude.ToDmsString());
        }

        [Fact]
        public void AssignDecimalValueCheckForCorrectDdRepresentation()
        {
            var latitude = new Latitude();
            latitude.DecimalValue = 35.696972M;
            Assert.Equal("N 35 41.81832", latitude.ToDdString());
        }

        [Fact]
        public void AssignDdValueCheckForCorrectDecimal()
        {
            var latitude = new Latitude();
            latitude.SetDdPoint(35, 41.818320M, NorthSouth.North);
            Assert.Equal(35.696972M, latitude.DecimalValue);
        }

        [Fact]
        public void AssignDmsValueCheckForCorrectDecimal()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(35, 41, 49.1M, NorthSouth.North);
            Assert.Equal(35.696972M, latitude.DecimalValue);
        }

        [Fact]
        public void AssignDecimalValueCheckForExactNumber()
        {
            var latitude = new Latitude();
            latitude.DecimalValue = -122.309617M;
            Assert.Equal(-122.309617M, latitude.DecimalValue);
        }

        [Fact]
        public void AssignDmsLatitiudeNorthDmsValueCheckForDecimal()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(35, 41, 49.1M, NorthSouth.North);
            Assert.Equal(35.696972M, latitude.DecimalValue);
            Assert.Equal(NorthSouth.North, latitude.NSHemisphere);
        }

        [Fact]
        public void AssignDmsLatitiudeSouthDmsValueCheckForDecimal()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(18, 48, 12.0M, NorthSouth.South);
            Assert.Equal(-18.803333M, latitude.DecimalValue);
            Assert.Equal(NorthSouth.South, latitude.NSHemisphere);
        }

        [Fact]
        public void AssignDmsLatitiudeSouthDmsValueCheckForDms()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(18, 48, 12.0M, NorthSouth.South);
            Assert.Equal((18, 48, 12.0M), latitude.DMS);
            Assert.Equal(NorthSouth.South, latitude.NSHemisphere);
        }

        [Fact]
        public void AssignDmsLatitiudeNorthDmsValueCheckForDd()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(35, 41, 49.1M, NorthSouth.North);
            Assert.Equal((35, 41.818320M), latitude.DD);
            Assert.Equal(NorthSouth.North, latitude.NSHemisphere);
        }

        [Fact]
        public void AssignDmsLatitiudeSouthDmsValueCheckForDd()
        {
            var latitude = new Latitude();
            latitude.SetDmsPoint(18, 48, 12.0M, NorthSouth.South);
            Assert.Equal((18, 48.199980M), latitude.DD);
            Assert.Equal(NorthSouth.South, latitude.NSHemisphere);
        }

        [Fact]
        public void AssignNegativeValueCheckForCorrectDms()
        {
            var latitude = new Latitude();
            latitude.DecimalValue = -33.969672M;
            Assert.Equal("33°58'10.8\"S", latitude.ToDmsString());
        }

        [Fact]
        public void CreateLatitudeFromDDString()
        {
            var latitude = new Latitude("N 35 41.818320", GeoStringFormat.DD);
            Assert.Equal("N 35 41.81832", latitude.ToDdString());
        }

        [Fact]
        public void CreateLatitudeFromDDString2()
        {
            var latitude = new Latitude("N 37 37.169167", GeoStringFormat.DD);
            Assert.Equal("37°37'10.1\"N", latitude.ToDmsString());
        }
    }
}
