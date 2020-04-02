using System;
using System.Collections.Generic;
using System.Text;

namespace QuantatyMeasurement
{
    public class Inches
    {
        int inch;
        public Inches(int inch)
        {
            this.inch = inch;
        }
        public int GetValue()
        {
            return this.inch;
        }
    }
}
