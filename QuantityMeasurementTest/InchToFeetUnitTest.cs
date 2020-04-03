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
        /// <summary>
        /// Checking Null Value and it return false if value is null
        /// </summary>
        [Test]
        public void Checking_NullRefrence_Value()
        {
            Inches inches = new Inches(12);
            Assert.IsFalse(inches.Equals(null));
        }
        /// <summary>
        /// Method for Checking feet Reference value
        /// </summary>
        [Test]
        public void Reference_Type_Inch_Value_Equal()
        {
            Inches inch = new Inches(2);
            Assert.IsTrue(inch.Cheking_Inch_Values_Equality(inch));
        }
        /// <summary>
        /// Checking The type of value
        /// </summary>
        [Test]
        public void Checking_Value_Type()
        {
            Inches inch = new Inches(2);
            var val1 = 3;
            Assert.IsTrue(inch.Equals(val1));
        }
        /// <summary>
        /// Method for Checking the value of  0 inch  and 0 inch
        /// </summary>
        [Test]
        public void Checking_Values_Equality()
        {
            Inches inch = new Inches(0);
            Inches inch1 = new Inches(0);
            Assert.IsTrue(inch.Cheking_Inch_Values_Equality(inch1));
        }
        /// <summary>
        /// This method for checking 1 inch and 2 inch is not equal
        /// </summary>
        [Test]
        public void Checking_Diffrent_Feet_Value()
        {
            var val1 = new Inches(1);
            var val2 = new Inches(2);
            Assert.IsFalse(val1.Cheking_Inch_Values_Equality(val2));
        }
    }
}
