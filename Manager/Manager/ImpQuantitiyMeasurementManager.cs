
namespace Manager
{
    using Model;
    using Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ImpQuantitiyMeasurementManager : IQuantityMeasurementManager
    {
        private readonly IQuantityMeasurementRepository quantityMeasurementRepository;

        public ImpQuantitiyMeasurementManager(IQuantityMeasurementRepository quantityMeasurementRepository)
        {
            this.quantityMeasurementRepository = quantityMeasurementRepository;
        }
        /// <summary>
        /// Method for cenverting Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public Fahranheit CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = quantityMeasurementRepository.CelsiusToFahrenheitConverter(celsius);
            return fahrenheitValue;
        }
        /// <summary>
        /// Method for converting Fahrenheit to Celsiu 
        /// </summary>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public Celsius FahrenheitToCelsiusCoverter(Fahranheit fahranheit)
        {
            var celsiusValue = quantityMeasurementRepository.FahrenheitToCelsiusCoverter(fahranheit);
            return celsiusValue;
        }

        /// <summary>
        /// Method for converting feet into inch
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var feetToInchValue = quantityMeasurementRepository.FeetToInchConverter(feet);
            return feetToInchValue;
        }

        public Kilogram GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = quantityMeasurementRepository.GramToKilogramConverter(gram);
            return kilogramValue;
        }

        /// <summary>
        /// Method for converting inch to feet value
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public Feet InchToFeetConverter(Inches inch)
        {
            var inchValue = quantityMeasurementRepository.InchToFeetConverter(inch);
            return inchValue;
        }

        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = quantityMeasurementRepository.KilogramToGramConverter(kilogram);
            return gramValue;
        }

        /// <summary>
        /// Method for convertinf yard value to feet
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Feet YardToFeetConverter(Yard yard)
        {
            var feetValue = quantityMeasurementRepository.YardToFeetConverter(yard);
            return feetValue;
        }
        /// <summary>
        /// Method for converting yard to inch
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Inches YardToInchConverter(Yard yard)
        {
            var inchValue = quantityMeasurementRepository.YardToInchConverter(yard);
            return inchValue;
        }
    }
}
