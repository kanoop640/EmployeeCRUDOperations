using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;


namespace QuantityMeasurement_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IQuantityMeasurementManager quantityMeasurementManager;

        public ValuesController(IQuantityMeasurementManager quantityMeasurementManager)
        {
            this.quantityMeasurementManager = quantityMeasurementManager;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public ActionResult<double> FeetToInchCoverter(Feet value)
        {
            var inchValue = quantityMeasurementManager.FeetToInchConverter(value);
            return inchValue.GetValue();
        }
        [Route("InchToFeet")]
        [HttpPost]
        public ActionResult<double> InchToFeethCoverter(Inches inch)
        {
            var feetValue = quantityMeasurementManager.InchToFeetConverter(inch);
            return feetValue.GetValue();
        }
        [Route("YardToFeet")]
        [HttpPost]
        public ActionResult<double> YardToFeetConveter(Yard yard)
        {
            var feetValue = quantityMeasurementManager.YardToFeetConverter(yard);
            return feetValue.GetValue();
        }
        [Route("YardtoInch")]
        [HttpPost]
        public ActionResult<double> YardToInchConverter(Yard yard)
        {
            var inchValue = quantityMeasurementManager.YardToInchConverter(yard);
            return inchValue.GetValue();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public ActionResult<double> KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = quantityMeasurementManager.KilogramToGramConverter(kilogram);
            return gramValue.GetValue();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public ActionResult<double> GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = quantityMeasurementManager.GramToKilogramConverter(gram);
            return kilogramValue.GetValue();
        }
        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public ActionResult<double> CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = quantityMeasurementManager.CelsiusToFahrenheitConverter(celsius);
            return fahrenheitValue.GetValue();
        }
        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public ActionResult<double> FahrenheittoCelsiusConverter(Fahranheit fahranheit)
        {
            var celsiusValue = quantityMeasurementManager.FahrenheitToCelsiusCoverter(fahranheit);
            return celsiusValue.GetValue();
        }
    }
}
