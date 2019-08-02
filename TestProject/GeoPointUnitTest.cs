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
            latitude.DD = (35, 41.818320M);
            Assert.Equal(35.696972M, latitude.DecimalValue);
        }

        [Fact]
        public void AssignDmsValueCheckForCorrectDecimal()
        {
            var latitude = new Latitude();
            latitude.DMS = (35, 41, 49.1M);
            Assert.Equal(35.696972M, latitude.DecimalValue);
        }
    }
}
