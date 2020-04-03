using System;
using System.Collections.Generic;
using System.Text;

namespace QuantatyMeasurement
{
    public class YardToFeet
    {
        public Feet Converte_Yard_To_Feet(Yard yard)
        {
            var yardToFeet = yard.GetValue() * 3;
            var feetValue = new Feet(yardToFeet);
            return feetValue;
        }
    }
}
