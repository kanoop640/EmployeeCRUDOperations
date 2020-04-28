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
            if (vehicleDetail.ParkingType == "wallet")
            {
                var entery = vehicleDetail.CheckIn;
                var exit = DateTime.Now;
                double hours = (exit - entery).TotalHours;
                var parkingCharges = vehicleDetail.RatePerHour * hours * 50;
                return Math.Min(parkingCharges, 50);
            }
            else
            {
                var entery = vehicleDetail.CheckIn;
                var exit = DateTime.Now;
                double hours = (exit - entery).TotalHours;
                var parkingCharges = vehicleDetail.RatePerHour * hours;
                return Math.Min(parkingCharges, 20);
            }
            
        }
    }
}
