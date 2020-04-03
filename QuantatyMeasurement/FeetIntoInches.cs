// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetIntoInches.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class FeetIntoInches
    {
        /// <summary>
        /// Method for converting feet into inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var a = feet.GetValue() * 12;
            Inches inch = new Inches(a);
            return inch;
        }
        /// <summary>
        /// This method for checking Feet value is equal to inch value or not
        /// </summary>
        /// <param name="feet"></param>
        /// <param name="inch"></param>
        /// <returns></returns>
        public bool Checking_Feet_And_Inch_Value_Equality(Feet feet,Inches inch)
        {
            var feetToInch = feet.GetValue() * 12;
            if (inch.GetValue() == feetToInch)
            {
                return true;
            }
            return false;
        }
    }
}
