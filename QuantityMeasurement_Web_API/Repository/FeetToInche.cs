
namespace QuantityMeasurement_Web_API.Repository
{
    using QuantityMeasurement_Web_API.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class FeetToInche
    {
        /// <summary>
        /// Method for converting feet into inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var feetToInchValue = feet.GetValue() * 12;
            Inches inchValue = new Inches(feetToInchValue);
            return inchValue;
        }
    }
}
