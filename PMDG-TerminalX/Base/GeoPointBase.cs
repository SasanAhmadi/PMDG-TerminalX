using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Base
{
    public abstract class GeoPointBase
    {
        protected (int Degrees, int Minutes, decimal Seconds) _dmsValue;
        protected decimal _decimalValue;
        protected (int Degrees, decimal Seconds) _ddValue;

        public GeoPointBase()
        {

        }

        public GeoPointBase(decimal location)
        {
            DecimalValue = location;
        }

        public (int Degrees, int Minutes, decimal Seconds) DMS
        {
            get { return _dmsValue; }
            protected set
            {
                if (value.Degrees < 0)
                    DecimalValue = decimal.Round(value.Degrees - (value.Seconds / 3600M) - (value.Minutes / 60M), 6);
                else
                    DecimalValue = decimal.Round((value.Seconds / 3600M) + (value.Minutes / 60M) + value.Degrees, 6);
            }
        }
        public decimal DecimalValue
        {
            get { return _decimalValue; }
            set
            {
                _dmsValue.Degrees = Math.Abs((int)decimal.Truncate(value));
                _dmsValue.Minutes = Math.Abs((int)decimal.Truncate((Math.Abs(value) - Math.Abs(decimal.Truncate(value))) * 60M));
                _dmsValue.Seconds = Math.Abs(decimal.Round(((Math.Abs(value) - Math.Abs(decimal.Truncate(value))) * 60M - DMS.Minutes) * 60M, 1));

                _ddValue.Degrees = Math.Abs((int)decimal.Truncate(value));
                _ddValue.Seconds = Math.Abs(decimal.Round((Math.Abs(value) - Math.Abs(decimal.Truncate(value))) * 60M, 6));

                _decimalValue = value;
            }
        }

        public (int Degrees, decimal Seconds) DD
        {
            get { return _ddValue; }
            protected set
            {
                if (value.Degrees < 0)
                    DecimalValue = decimal.Round(-(value.Seconds / 60M) - value.Degrees, 6);
                else
                    DecimalValue = decimal.Round((value.Seconds / 60M) + value.Degrees, 6);
            }
        }

        public virtual string ToDmsString()
        {
            return _dmsValue.Degrees.ToString("0;0;0") + "°" + _dmsValue.Minutes.ToString("00;00;00") + "'" + _dmsValue.Seconds.ToString("00.0;00.0;00.0") + "\"";
        }

        public virtual string ToDdString()
        {
            return _ddValue.Degrees.ToString("0;0;0") + " " + _ddValue.Seconds.ToString("0.000000;0.000000;0.000000");
        }
    }
}