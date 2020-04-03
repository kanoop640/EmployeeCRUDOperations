// --------------------------------------------------------------------------------------------------------------------
// <copyright file="YardToInch.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class YardToInch
    {
        /// <summary>
        /// This method is checking that inch  and yard value is equal or not
        /// </summary>
        /// <param name="yard"></param>
        /// <param name="inches"></param>
        /// <returns></returns>
        public bool? Checking_Equality_Of_Yard_And_Inch(Yard yard, Inches inches)
        {
            var inchValue = yard.GetValue() * 3 * 12;
            if (inches.GetValue() == inchValue)
            {
                return true;
            }
            return false;
        }
    }
}
