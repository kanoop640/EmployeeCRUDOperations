﻿using System;
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
        private readonly IsecurityParkingManager policeManager;

        public PoliceParkingController(IsecurityParkingManager pollicemanager)
        {
            this.policeManager = pollicemanager;
        }

        [Route("PoliceParking")]
        [HttpPost]
        public async Task<IActionResult>  PoliceParking(ParkingModel parkingModel)
        {
            var result = await this.policeManager.Parking(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            return this.BadRequest();
        }
        [Route("PoliceUnparking")]
        [HttpDelete]
        public ActionResult PoliceUnparking(int id)
        {
            var result = policeManager.Unparking(id);
            if (result > 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
        [Route("GetAllVehicle")]
        [HttpGet]
        public IEnumerable<ParkingModel> GetAllVehicle()
        {
            return policeManager.GetAllVehicle();
        }
    }
}
