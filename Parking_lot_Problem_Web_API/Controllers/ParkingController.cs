using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parking_lot_Problem_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : Controller
    {
        private readonly IParkingRepository parkingRepository;

        public ParkingController(IParkingRepository parkingRepository)
        {
            this.parkingRepository = parkingRepository;
        }

        [Route("Parking")]
        [HttpPost]
        public async Task<IActionResult>  Parking(string vehicleNumber, double ratePerHour)
        {
            var result = await this.parkingRepository.Parking(vehicleNumber, ratePerHour);
            if (result == 1)
            {
                return this.Ok();
            }
            return this.BadRequest();
        }
    }
}
