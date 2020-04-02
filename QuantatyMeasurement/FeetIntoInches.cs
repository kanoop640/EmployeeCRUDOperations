using System;
using System.Collections.Generic;
using System.Text;

namespace QuantatyMeasurement
{
    public class FeetIntoInches
    {
       
        public Inches FeetToInchConverter(Feet feet)
        {
            var a = feet.GetValue() * 12;
            Inches inch = new Inches(a);
            return inch;
        }
    }
}
