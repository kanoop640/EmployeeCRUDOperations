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
    }
}