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
    /// <summary>
    /// Feet Related Test Case Class
    /// </summary>
    public class FeetInchesUnitTest
    {
        /// <summary>
        /// Method For Converting Feet to inch
        /// </summary>
        [Test]
        public void ConvertingFeetIntoInch()
        {
            Feet feet = new Feet(2);
            FeetIntoInches feetIntoInches = new FeetIntoInches();
            Inches inch = feetIntoInches.FeetToInchConverter(feet);
            Assert.AreEqual(inch.GetValue(), feetIntoInches.FeetToInchConverter(feet).GetValue());
        }
        /// <summary>
        /// Method for checking value type in feet
        /// </summary>
        [Test]
        public void NullReference_Value_Equals()
        {
            Feet feet = new Feet(1);
            Assert.IsFalse(feet.Equals(null));
        }
        /// <summary>
        /// Method for Checking feet Reference value
        /// </summary>
        [Test]
        public void Reference_Type_Feet_Value_Equal()
        {
            Feet feet = new Feet(2);
            Assert.IsTrue(feet.ConverteToFeet(feet));
        }
        /// <summary>
        /// Checking The type of value
        /// </summary>
        [Test]
        public void Checking_Value_Type()
        {
            Feet feet = new Feet(2);
            var val1 = 3;
            Assert.IsTrue(feet.Equals(val1));
        }
        /// <summary>
        /// Method for Checking the value of  feet type
        /// </summary>
        [Test]
        public void Checking_Values_Equality()
        {
            Feet feet = new Feet(0);
            Feet feet1 = new Feet(0);
            Assert.IsTrue(feet.ConverteToFeet(feet1));
        }
        /// <summary>
        /// This method for checking 1ft and 2ft is not equal
        /// </summary>
        [Test]
        public void Checking_Diffrent_Feet_Value()
        {
            var val1 = new Feet(1);
            var val2 = new Feet(2);
            Assert.IsFalse(val1.ConverteToFeet(val2));
        }
        /// <summary>
        /// This method for checking Feet and Inch value 
        /// </summary>
        [Test]
        public void Checking_Feet_And_Inch_Value_Equality()
        {
            var feetValue = new Feet(1);
            var inchValue = new Inches(12);
            FeetIntoInches feetIntoInches = new FeetIntoInches();
            Assert.IsTrue(feetIntoInches.Checking_Feet_And_Inch_Value_Equality(feetValue, inchValue));
        }
        /// <summary>
        /// Method for checking 1ft is not equalt to 24 inch
        /// </summary>
        [Test]
        public void Checking_Feet_And_Inch_Value_Not_Equality()
        {
            var feetValue = new Feet(1);
            var inchValue = new Inches(24);
            FeetIntoInches feetIntoInches = new FeetIntoInches();
            Assert.IsFalse(feetIntoInches.Checking_Feet_And_Inch_Value_Equality(feetValue, inchValue));
        }
    }
}