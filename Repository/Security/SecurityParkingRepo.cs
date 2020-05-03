using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Security
{
    public class SecurityParkingRepo : ISecurityParkingRopo
    {
        private readonly UserDBContext userDBContext;

        public SecurityParkingRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        private readonly int Vallet_Parking_Charge = 50;
        private readonly int Minimum_Parking_Charge = 30;
        public double SecurityUnparking(int slotNumber)
        {
            try
            {
                var vehicleDetail = userDBContext.Parkings.Find(slotNumber);
                var enteryTime = vehicleDetail.CheckIn;
                var exitTime = DateTime.Now;
                double hours = (exitTime - enteryTime).TotalHours;
                if (vehicleDetail.ParkingType == "valet")
                {
                    var charges = vehicleDetail.RatePerHour * hours * Vallet_Parking_Charge;
                    userDBContext.Parkings.Remove(vehicleDetail);
                    userDBContext.SaveChangesAsync();
                    return Math.Max(charges, Minimum_Parking_Charge);
                }

                var parkingCharge = vehicleDetail.RatePerHour * hours;
                userDBContext.Parkings.Remove(vehicleDetail);
                userDBContext.SaveChangesAsync();
                return Math.Max(parkingCharge, Minimum_Parking_Charge);
            }
            catch (Exception)
            {
                throw new Exception("Vehicle is not found");
            }
        }

        public Task<int> SecurityParking(ParkingModel parkingModel)
        {
            var entryTime = DateTime.Now;
            parkingModel.CheckIn = entryTime;
            userDBContext.Parkings.Add(parkingModel);
            var result = userDBContext.SaveChangesAsync();
            return result;
            
        }
    }
}
