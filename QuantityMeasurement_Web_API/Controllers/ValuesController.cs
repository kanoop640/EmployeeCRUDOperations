using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurement_Web_API.Model;
using QuantityMeasurement_Web_API.Repository;

namespace QuantityMeasurement_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConverter _converter;

        public ValuesController(IConverter converter)
        {
            _converter = converter;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public ActionResult<double> FeetToInchCoverter(Feet value)
        {
            var inchValue = _converter.FeetToInchConverter(value);
            return inchValue.GetValue();
        }
        [Route("InchToFeet")]
        [HttpPost]
        public ActionResult<double> InchToFeethCoverter(Inches inch)
        {
            var feetValue = _converter.InchToFeetConverter(inch);
            return feetValue.GetValue();
        }
        [Route("YardToFeet")]
        [HttpPost]
        public ActionResult<double> YardToFeetConveter(Yard yard)
        {
            var feetValue = _converter.YardToFeetConverter(yard);
            return feetValue.GetValue();
        }
        [Route("YardtoInch")]
        [HttpPost]
        public ActionResult<double> YardToInchConverter(Yard yard)
        {
            var inchValue = _converter.YardToInchConverter(yard);
            return inchValue.GetValue();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public ActionResult<double> KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = _converter.KilogramToGramConverter(kilogram);
            return gramValue.GetValue();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public ActionResult<double> GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = _converter.GramToKilogramConverter(gram);
            return kilogramValue.GetValue();
        }
        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public ActionResult<double> CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = _converter.CelsiusToFahrenheitConverter(celsius);
            return fahrenheitValue.GetValue();
        }
        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public ActionResult<double> FahrenheittoCelsiusConverter(Fahranheit fahranheit)
        {
            var celsiusValue = _converter.FahrenheitToCelsiusCoverter(fahranheit);
            return celsiusValue.GetValue();
        }
    }
}
