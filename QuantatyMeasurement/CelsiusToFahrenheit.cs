// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CelsiusToFahrenheit.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class CelsiusToFahrenheit
    {
        /// <summary>
        /// this method is for checking the equality of Celsius and fahranheit value
        /// </summary>
        /// <param name="celsius"></param>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Celsius_And_Fahrenheit_Value(Celsius celsius,Fahranheit fahranheit)
        {
            var fahranheitValue = (celsius.GetValue() * 9 / 5) + 32;
            if (fahranheit.GetValue() == fahranheitValue)
            {
                return true;
            }
            return false;
        }
    }
}
