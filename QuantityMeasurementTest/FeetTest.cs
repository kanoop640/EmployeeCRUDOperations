using NUnit.Framework;
using QuantatyMeasurement;

namespace QuantityMeasurementTest
{
    public class FeetTest
    {
      
        [Test]
        public void ChecckingFeetEquality()
        {
            Feet feet = (int)0;
            Assert.AreEqual(feet,0);
        }
    }
}