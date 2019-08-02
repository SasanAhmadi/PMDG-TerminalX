using System;
using System.Collections.Generic;
using System.Text;

namespace PMDG_TerminalX.Base
{
    public abstract class GeoPointBase
    {
        protected event EventHandler<decimal> IdentifyHemisphereEvent;
        protected (int Degrees, int Minutes, decimal Seconds) _dmsValue;
        protected decimal _decimalValue;
        protected (int Degrees, decimal Seconds) _ddValue;

        public (int Degrees, int Minutes, decimal Seconds) DMS
        {
            get { return _dmsValue; }
            set
            {
                if (value.Degrees < 0)
                    DecimalValue = -(value.Seconds / 3600) - (value.Minutes / 60) + value.Degrees;
                else
                    DecimalValue = (value.Seconds / 3600) + (value.Minutes / 60) + value.Degrees;

                IdentifyHemisphereEvent(this, _decimalValue);
            }
        }
        public decimal DecimalValue
        {
            get { return _decimalValue; }
            set
            {
                _dmsValue.Degrees = (int)decimal.Truncate(value);
                _dmsValue.Minutes = (int)decimal.Truncate((value - decimal.Truncate(value)) * 60);
                _dmsValue.Seconds = decimal.Round((((value - decimal.Truncate(value)) * 60) - DMS.Minutes) * 60, 1);

                _ddValue.Degrees = (int)decimal.Truncate(value);
                _ddValue.Seconds = decimal.Round((value - decimal.Truncate(value)) * 60, 6);

                _decimalValue = value;

                IdentifyHemisphereEvent(this, _decimalValue);
            }
        }

        public (int Degrees, decimal Seconds) DD
        {
            get { return _ddValue; }
            set {
                DecimalValue = decimal.Round(value.Seconds / 60M, 6) + value.Degrees;
            }
        }

        public virtual string ToDmsString()
        {
            return _dmsValue.Degrees.ToString("0;0;0") + "°" + _dmsValue.Minutes.ToString("0;0;0") + "'" + _dmsValue.Seconds.ToString("00.0;00.0;00.0") + "\"";
        }

        public virtual string ToDdString()
        {
            return _ddValue.Degrees.ToString("0;0;0") + " " + _ddValue.Seconds.ToString("0.000000;0.000000;0.000000");
        }
    }
}
