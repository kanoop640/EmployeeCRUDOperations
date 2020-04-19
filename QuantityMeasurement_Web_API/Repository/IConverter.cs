using QuantityMeasurement_Web_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantityMeasurement_Web_API.Repository
{
    public interface IConverter
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
