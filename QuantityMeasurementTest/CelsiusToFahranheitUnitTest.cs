// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CelsiusToFahranheitUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantatyMeasurement;
    using System;
    using System.Collections.Generic;
    using System.Text;
    class CelsiusToFahranheitUnitTest
    {
        /// <summary>
        /// Checking the equality of two celsius value
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_Value()
        {
            Celsius celsius = new Celsius(1);
            Celsius celsius1 = new Celsius(1);
            Assert.IsTrue(celsius.Cheching_Equality_Of_Celsius_Value(celsius1));
        }
        /// <summary>
        /// This method is checking the value of Celsius and fahranheit
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_And_Fahranheit_Value()
        {
            Celsius celsius = new Celsius(1);
            Fahranheit fahranheit = new Fahranheit(33.8);
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.IsTrue(celsiusToFahrenheit.Checking_Equality_Of_Celsius_And_Fahrenheit_Value(celsius, fahranheit));
        }
        /// <summary>
        /// Checking the equality of two celsius value
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Diffrent_Celsius_Value()
        {
            Celsius celsius = new Celsius(1);
            Celsius celsius1 = new Celsius(2);
            Assert.IsFalse(celsius.Cheching_Equality_Of_Celsius_Value(celsius1));
        }
    }
}
