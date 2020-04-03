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
        /// <summary>
        /// This mehod is checking that 1 yard is equal to 3 ft
        /// </summary>
        [Test]
        public void Cheking_3ft_Equal_To_1Yard()
        {
            var feetValue = new Feet(3);
            var yardValue = new Yard(1);
            YardToFeet yardToFeet = new YardToFeet();
            Assert.IsTrue(yardToFeet.Checking_Yard_And_Feet_Value_Equality(feetValue, yardValue));
        }
    }
}
