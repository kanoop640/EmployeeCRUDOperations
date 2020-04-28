using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ParkingRepository : IParkingRepository
    {
        public ParkingRepository(UserDBContext userDBContext)
        {
            _userDBContext = userDBContext;
        }

        private readonly UserDBContext _userDBContext;

        public Task<int> Parking(string vehicleNumber, double ratePerHour)
        {
            ParkingModel parkingModel = new ParkingModel();
            parkingModel.VehicleNumber = vehicleNumber;
            parkingModel.RatePerHour = ratePerHour;
            parkingModel.CheckIn = DateTime.Now;
            _userDBContext.Parkings.Add(parkingModel);
            var result = _userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
