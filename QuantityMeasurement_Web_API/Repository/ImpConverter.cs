
namespace QuantityMeasurement_Web_API.Repository
{
    using QuantityMeasurement_Web_API.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ImpConverter :IConverter
    {
        /// <summary>
        /// Method for cenverting Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public Fahranheit CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = (celsius.GetValue() +32)*9/5;
            Fahranheit fahranheit = new Fahranheit(fahrenheitValue);
            return fahranheit;
        }
        /// <summary>
        /// Method for converting Fahrenheit to Celsiu 
        /// </summary>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public Celsius FahrenheitToCelsiusCoverter(Fahranheit fahranheit)
        {
            var celsiusValue = (fahranheit.GetValue() - 32) * 5 / 9;
            Celsius celsius = new Celsius(celsiusValue);
            return celsius;
        }

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

        public Kilogram GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = gram.GetValue() / 1000;
            Kilogram kilogram = new Kilogram(kilogramValue);
            return kilogram;
        }

        /// <summary>
        /// Method for converting inch to feet value
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public Feet InchToFeetConverter(Inches inch)
        {
            var inchValue = inch.GetValue() / 12;
            Feet feet = new Feet(inchValue);
            return feet;
        }

        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = kilogram.GetValue() * 1000;
            Gram gram = new Gram(gramValue);
            return gram;
        }

        /// <summary>
        /// Method for convertinf yard value to feet
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Feet YardToFeetConverter(Yard yard)
        {
            var yardToFeet = yard.GetValue() * 3;
            var feetValue = new Feet(yardToFeet);
            return feetValue;
        }
        /// <summary>
        /// Method for converting yard to inch
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Inches YardToInchConverter(Yard yard)
        {
            var inchValue = yard.GetValue() * 36;
            Inches inches = new Inches(inchValue);
            return inches;
        }
    }
}
