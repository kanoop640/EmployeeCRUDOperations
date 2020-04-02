﻿using NUnit.Framework;
using QuantatyMeasurement;

namespace QuantityMeasurementTest
{
    public class FeetInchesUnitTest
    {
        [Test]
        public void ConvertingFeetIntoInch()
        {
            Feet feet = new Feet(2);
            FeetIntoInches feetIntoInches = new FeetIntoInches();
            Inches inch = feetIntoInches.FeetToInchConverter(feet);
            Assert.AreEqual(inch.GetValue(), feetIntoInches.FeetToInchConverter(feet).GetValue());

        }
    }
}