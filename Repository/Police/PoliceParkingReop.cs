using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Police
{
    public class PoliceParkingReop : IPoliceParkingRepo
    {
        private readonly UserDBContext userDBContext;

        public PoliceParkingReop(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        private readonly int Vallet_Parking_Charge = 50;
        private readonly int Minimum_Parking_Charge = 30;
        List<ParkingModel> vehicleList = new List<ParkingModel>(2);
        int count = 0;
        public Task<int> Parking(ParkingModel parkingModel)
        {
            parkingModel.CheckIn = DateTime.Now;
            userDBContext.Parkings.Add(parkingModel);
            var result = userDBContext.SaveChangesAsync();
            return result;

        }
        public int GetSlot()
        {
            var vehicles = userDBContext.Parkings;
            foreach(ParkingModel vehicle in vehicles)
            {
                if (vehicle.DriverType == "Police")
                {
                    count++;
                }
            }
            return count;
        }
        public double Unparking(int slotNumber)
        {
           ParkingModel vehicleDetail= userDBContext.Parkings.Find(slotNumber);
            try
            {
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
            catch (Exception)
            {
                throw new Exception("Vehicle is not found");
            }
        }
        public IEnumerable<ParkingModel> GetAllVehicle()
        {
            try
            {
                var vehicles = userDBContext.Parkings;
                return vehicles;
            }
            catch (Exception)
            {

                throw new Exception("There is no vehicle in the parking");
            }
        }
    }
}
