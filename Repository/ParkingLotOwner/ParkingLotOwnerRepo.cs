using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.ParkingLotOwner
{
    public class ParkingLotOwnerRepo : IParkingLotOwnerRepo
    {
        private readonly UserDBContext userDBContext;

        public ParkingLotOwnerRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        List<ParkingModel> vehicleDetails = new List<ParkingModel>();
        public List<ParkingModel> GetAllDriverTypeVehicle()
        {
            List<ParkingModel> driverVehicle = new List<ParkingModel>();
            var vehicles = userDBContext.Parkings;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.DriverType == "Driver")
                {
                    driverVehicle.Add(vehicle);
                }
            }
            return driverVehicle;
        }

        public List<ParkingModel> GetAllOwnerTypeVehicle()
        {
            List<ParkingModel> ownerVehicle = new List<ParkingModel>();
            var vehicles = userDBContext.Parkings;
            foreach(var vehicle in vehicles)
            {
                if (vehicle.DriverType == "Owner")
                {
                    ownerVehicle.Add(vehicle);
                }
            }
            return ownerVehicle;
        }

        public List<ParkingModel> GetAllPoliceTypeVehicle()
        {
            List<ParkingModel> policeVehicle = new List<ParkingModel>();
            var vehicles = userDBContext.Parkings;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.DriverType == "Police")
                {
                    policeVehicle.Add(vehicle);
                }
            }
            return policeVehicle;
        }

        public List<ParkingModel> GetAllSecurityTypeVehicle()
        {
            List<ParkingModel> securityVehicle = new List<ParkingModel>();
            var vehicles = userDBContext.Parkings;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.DriverType == "Security")
                {
                    securityVehicle.Add(vehicle);
                }
            }
            return securityVehicle;
        }

        public IEnumerable<ParkingModel> GetAllVehicle()
        {
            var vehicles = userDBContext.Parkings;
            foreach (var vehicle in vehicles)
            {
                vehicleDetails.Add(vehicle);
            }
            return vehicleDetails;
        }
    }
}
