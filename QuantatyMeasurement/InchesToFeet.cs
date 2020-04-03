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
    public class InchesToFeet
    {
        /// <summary>
        /// This method is converting Inche to Feet
        /// </summary>
        /// <param name="inches"></param>
        /// <returns></returns>
        public Feet Convering_Inch_To_Feet(Inches inches) 
        {
            var inchValue = inches.GetValue() / 12;
            Feet feet = new Feet(inchValue);
            return feet;
        }
    }
}
