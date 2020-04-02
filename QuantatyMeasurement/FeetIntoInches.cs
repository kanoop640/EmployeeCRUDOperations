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
    }
}
