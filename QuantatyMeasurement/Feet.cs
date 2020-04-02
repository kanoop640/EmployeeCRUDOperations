
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Feet
    {
        int feet;                                         

        public Feet(int feet)
        {
            this.feet = feet;
        }
        public int GetValue()
        {
            return this.feet;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.feet.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;
        }
    }
    
}
