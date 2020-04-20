using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IQuantityMeasurementRepository
    {
        Inches FeetToInchConverter(Feet feet);
        Feet InchToFeetConverter(Inches inch);
        Feet YardToFeetConverter(Yard yard);
        Inches YardToInchConverter(Yard yard);
        Gram KilogramToGramConverter(Kilogram kilogram);
        Kilogram GramToKilogramConverter(Gram gram);
        Fahranheit CelsiusToFahrenheitConverter(Celsius celsius);
        Celsius FahrenheitToCelsiusCoverter(Fahranheit fahranheit);
    }
}
