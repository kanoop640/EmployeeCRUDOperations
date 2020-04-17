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
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [Route("FeetToInch")]
        [HttpGet]
        public double FeetToInchCoverter(double value)
        {
            Feet feetValue = new Feet(value);
            FeetToInche feetToInche = new FeetToInche();
             var inchValue=feetToInche.FeetToInchConverter(feetValue);
            return inchValue.GetValue();
        }
    }
}
