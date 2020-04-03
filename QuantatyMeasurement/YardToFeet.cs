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

        /// <summary>
        /// This method is checking the equality of feet and yard value
        /// </summary>
        /// <param name="feetValue"></param>
        /// <param name="yardValue"></param>
        /// <returns></returns>
        public bool? Checking_Yard_And_Feet_Value_Equality(Feet feetValue, Yard yardValue)
        {
            var value = yardValue.GetValue() * 3;
            if (feetValue.GetValue() == value)
            {
                return true;
            }
            return false;
        }
    }
}
