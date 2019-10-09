using PMDG_TerminalX.Common;
using PMDG_TerminalX.Geo;
using System;
using Xunit;

namespace TestProject
{
    public class GeoPointUnitTest
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
            Assert.Equal("N 35 41.818320", latitude.ToDdString());
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
        public void AssignNegativeValueCheckForCorrectDms()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = -122.309617M;
            Assert.Equal("122°18'34.6\"W", longitude.ToDmsString());
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
            latitude.SetDmsPoint(35,41,49.1M, NorthSouth.North);
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
        public void CheckGeoLocationDmsStringOutput()
        {
            var geoLocation = new GeoLocation(35.410179m, 51.155586m);
            Assert.Equal("35°24'36.6\"N 51°09'20.1\"E", geoLocation.ToDmsString());


        }
    }
}
