using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotModel;
using Repository;
using Repository.Police;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parking_lot_Problem_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliceParkingController : Controller
    {
        private readonly IPoliceParking policeParking;

        public PoliceParkingController(IPoliceParking policeParking)
        {
            this.policeParking = policeParking;
        }

        [Route("PoliceParking")]
        [HttpPost]
        public async Task<IActionResult>  PoliceParking(ParkingModel parkingModel)
        {
            var result = await this.policeParking.Parking(parkingModel);
            if (result == 1)
            {
                return this.Ok();
            }
            return this.BadRequest();
        }
        [Route("PloliceUnparking")]
        [HttpDelete]
        public ParkingModel DeleteParking(int id)
        {
            var result = policeParking.DeleteParking(id);
            return result;
        }
    }
}
