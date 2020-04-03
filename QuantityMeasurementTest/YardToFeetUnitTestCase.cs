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
    public class YardToFeetUnitTestCase
    {
        /// <summary>
        /// This Method converting yard to feet value
        /// </summary>
        [Test]
        public void Converting_Yard_To_Feet()
        {
            Yard yard = new Yard(1);
            YardToFeet yardToFeet = new YardToFeet();
            var feetValue = yardToFeet.Converte_Yard_To_Feet(yard);
            Assert.AreEqual(feetValue.GetValue(), 3);
        }
    }
}
