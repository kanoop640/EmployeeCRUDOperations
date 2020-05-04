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
    public class SecurityParkingController : Controller
    {
        private readonly IsecurityParkingManager securityManager;

        public SecurityParkingController(IsecurityParkingManager securityManager)
        {
            this.securityManager = securityManager;
        }

        [Route("SecurityParking")]
        [HttpPost]
        public async Task<IActionResult> SecurityParking(ParkingModel parkingModel)
        {
            var result = await this.securityManager.Parking(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            return this.BadRequest();
        }
        [Route("SecurityUnparking")]
        [HttpDelete]
        public ActionResult SecurityUnparking(int id)
        {
            var result = securityManager.Unparking(id);
            if (result > 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        
    }
}
