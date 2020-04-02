
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantatyMeasurement;
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
        [Test]
        public void NullReference_Value_Equals()
        {
            Feet feet = new Feet(1);
            Assert.IsFalse(feet.Equals(null));
        }
    }
}