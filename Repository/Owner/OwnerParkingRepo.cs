using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Owner
{
    public class OwnerParkingRepo : IOwnerParkingRepo
    {
        private readonly UserDBContext userDBContext;

        public OwnerParkingRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        private readonly int Vallet_Parking_Charge = 50;
        private readonly int Minimum_Parking_Charge = 30;
        List<ParkingModel> vehicleList = new List<ParkingModel>(3);
        public IEnumerable<ParkingModel> GetAllVehicle()
        {
            var vehicles = userDBContext.Parkings;
            return vehicles;
        }

        public Task<int> Ownerparking(ParkingModel parkingModel)
        {
            if (GetSlot())
            {
                parkingModel.CheckIn = DateTime.Now;
                userDBContext.Parkings.Add(parkingModel);
                var result = userDBContext.SaveChangesAsync();
                return result;
            }
            throw new Exception("Lot is full");
        }

        public bool GetSlot()
        {
            var vehicles = userDBContext.Parkings;
            foreach (ParkingModel vehicle in vehicles)
            {
                if (vehicle.DriverType == "Police")
                {
                    vehicleList.Add(vehicle);
                }
            }
            if (vehicleList.Count != vehicleList.Capacity)
            {
                return true;
            }
            return false;
        }
        public double OwnerUnparking(int slotNumber)
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
    }
}
