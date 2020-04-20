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
        private readonly IQuantityMeasurementManager _quantityMeasurementManager;

        public ValuesController(IQuantityMeasurementManager quantityMeasurementManager)
        {
            _quantityMeasurementManager = quantityMeasurementManager;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInchCoverter(Feet value)
        {
            var inchValue = _quantityMeasurementManager.FeetToInchConverter(value);
            if (inchValue != null)
            {
                return this.Ok(inchValue.GetValue());
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeethCoverter(Inches inch)
        {
            var feetValue = _quantityMeasurementManager.InchToFeetConverter(inch);
            if (feetValue != null)
            {
             return this.Ok(feetValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("YardToFeet")]
        [HttpPost]
        public IActionResult YardToFeetConveter(Yard yard)
        {
            var feetValue = _quantityMeasurementManager.YardToFeetConverter(yard);
            if (feetValue != null)
            {
                return this.Ok(feetValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("YardtoInch")]
        [HttpPost]
        public ActionResult<double> YardToInchConverter(Yard yard)
        {
            var inchValue = _quantityMeasurementManager.YardToInchConverter(yard);
            if (inchValue != null)
            {
                return this.Ok(inchValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public ActionResult<double> KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = _quantityMeasurementManager.KilogramToGramConverter(kilogram);
            if (gramValue!=null)
            {
                return this.Ok(gramValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public ActionResult<double> GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = _quantityMeasurementManager.GramToKilogramConverter(gram);
            if(kilogramValue != null)
            {
                return this.Ok(kilogramValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public ActionResult<double> CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = _quantityMeasurementManager.CelsiusToFahrenheitConverter(celsius);
            if(fahrenheitValue != null)
            {
                return this.Ok(fahrenheitValue.GetValue());
            }
            return this.BadRequest();
        }

        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public ActionResult<double> FahrenheittoCelsiusConverter(Fahranheit fahranheit)
        {
            var celsiusValue = _quantityMeasurementManager.FahrenheitToCelsiusCoverter(fahranheit);
            if (celsiusValue != null)
            {
                return this.Ok(celsiusValue.GetValue());
            }
            return this.BadRequest();
        }
    }
}
