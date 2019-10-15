using PMDGTerminalX.Common;
using PMDGTerminalX.Geo;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TerminalXTest
{
    public class LongitudeTest
    {
        [Fact]
        public void AssignDecimalValueCheckForCorrectConversionToDmsAndDd()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = 35.696972M;
            Assert.Equal((35, 41, 49.1M), longitude.DMS);
        }

        [Fact]
        public void AssignDecimalValueCheckForCorrectDmsRepresentation()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = -122.480292M;
            Assert.Equal("122°28'49.1\"W", longitude.ToDmsString());
        }

        [Fact]
        public void AssignDecimalValueCheckForCorrectDdRepresentation()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = -122.480292M;
            Assert.Contains("W 122 28.8175", longitude.ToDdString());
        }

        [Fact]
        public void AssignDdValueCheckForCorrectDecimal()
        {
            var longitude = new Longitude();
            longitude.SetDdPoint(122, 28.8175M, EasthWest.West);
            Assert.Equal(-122.480292M, longitude.DecimalValue);
        }

        [Fact]
        public void AssignDmsValueCheckForCorrectDecimal()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(122, 28, 49.1M, EasthWest.West);
            Assert.Equal(-122.480306M, longitude.DecimalValue);
        }

        [Fact]
        public void AssignDecimalValueCheckForExactNumber()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = -122.309617M;
            Assert.Equal(-122.309617M, longitude.DecimalValue);
        }

        [Fact]
        public void AssignDmsLongitudeWestDmsValueCheckForDecimal()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(122, 22, 26.0M, EasthWest.West);
            Assert.Equal(-122.3738M, longitude.DecimalValue.TruncateDecimal(4));
            Assert.Equal(EasthWest.West, longitude.EWHemisphere);
        }

        [Fact]
        public void AssignDmsLongitudeEastDmsValueCheckForDecimal()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(51, 10, 42.5M, EasthWest.East);
            Assert.Equal(51.178472M, longitude.DecimalValue);
            Assert.Equal(EasthWest.East, longitude.EWHemisphere);
        }

        [Fact]
        public void AssignDmsLongitudeEastDmsValueCheckForDms()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(51, 10, 42.5M, EasthWest.East);
            Assert.Equal((51, 10, 42.5M), longitude.DMS);
            Assert.Equal(EasthWest.East, longitude.EWHemisphere);
        }

        [Fact]
        public void AssignDmsLongitudeWesthDmsValueCheckForDd()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(122, 22, 26.0M, EasthWest.West);
            Assert.Equal((122, 22.433340M), longitude.DD);
            Assert.Equal(EasthWest.West, longitude.EWHemisphere);
        }

        [Fact]
        public void AssignDmsLongitudeEastDmsValueCheckForDd()
        {
            var longitude = new Longitude();
            longitude.SetDmsPoint(51, 9, 33.0M, EasthWest.East);
            Assert.Equal((51, 9.55002M), longitude.DD);
            Assert.Equal(EasthWest.East, longitude.EWHemisphere);
        }

        [Fact]
        public void AssignNegativeValueCheckForCorrectDms()
        {
            var longitude = new Longitude();
            longitude.DecimalValue = -122.309617M;
            Assert.Equal("122°18'34.6\"W", longitude.ToDmsString());
        }

        [Fact]
        public void CreateLongitudeFromDDString()
        {
            var longitude = new Longitude("W 122 28.817520", GeoStringFormat.DD);
            Assert.Equal("W 122 28.81752", longitude.ToDdString());
        }
    }
}
