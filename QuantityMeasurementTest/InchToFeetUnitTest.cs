// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeetInchesUnitTest.cs" company="Bridgelabz">
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
    public class InchToFeetUnitTest
    {
        /// <summary>
        /// This method converting inch value into Feet value
        /// </summary>
        [Test]
        public void Converting_Inch_To_Feet()
        {
            Inches inches = new Inches(12);
            InchesToFeet inchToFeet = new InchesToFeet();
            var feetValue=inchToFeet.Convering_Inch_To_Feet(inches);
            Assert.AreEqual(feetValue.GetValue(), 1);
        }

    }
}
