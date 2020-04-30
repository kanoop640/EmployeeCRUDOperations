using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Police
{
    public class PoliceParking : IPoliceParking
    {
        private readonly UserDBContext userDBContext;

        public PoliceParking(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        private readonly int Vallet_Parking_Charge = 50;
        private readonly int Minimum_Parking_Charge = 30;
        public Task<int> Parking(ParkingModel parkingModel)
        {
            parkingModel.CheckIn = DateTime.Now;
            if (parkingModel.SlotNumber > 25)
            {
                throw new Exception("Slot is full");
            }
            userDBContext.Parkings.Add(parkingModel);
            var result = userDBContext.SaveChangesAsync();
            return result;

        }
        public ParkingModel DeleteParking(int slotNumber)
        {
           ParkingModel parkingModel= userDBContext.Parkings.Find(slotNumber);
            if (parkingModel != null)
            {
                userDBContext.Parkings.Remove(parkingModel);
                userDBContext.SaveChangesAsync();
            }
            return parkingModel;
        }
        public double ParkingCharges(int slotNumber)
        {
            var vehicleDetail = userDBContext.Parkings.Find(slotNumber);
            if (vehicleDetail.ParkingType == "valet")
            {
                var entery = vehicleDetail.CheckIn;
                var exit = DateTime.Now;
                double hours = (exit - entery).TotalHours;
                var parkingCharges = vehicleDetail.RatePerHour * hours * Vallet_Parking_Charge;
                return Math.Min(parkingCharges, Minimum_Parking_Charge);
            }
            else
            {
                var entery = vehicleDetail.CheckIn;
                var exit = DateTime.Now;
                double hours = (exit - entery).TotalHours;
                var parkingCharges = vehicleDetail.RatePerHour * hours;
                return Math.Min(parkingCharges, Minimum_Parking_Charge);
            }
            
        }
    }
}
