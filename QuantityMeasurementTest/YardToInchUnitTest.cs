
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantatyMeasurement;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class YardToInchUnitTest
    {
        /// <summary>
        /// This method for checking that 1 inch and 1 yard is not equal
        /// </summary>
        [Test]
        public void Checking_1Inch__And_1Yard_Equality()
        {
            Inches inches = new Inches(1);
            Yard yard = new Yard(1);
            YardToInch yardToInch = new YardToInch();
            Assert.IsFalse(yardToInch.Checking_Equality_Of_Yard_And_Inch(yard, inches));
        }
    }
}
