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
    }
}
