using ParkingLotModel;
using Repository.Police;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Manager
{
    public class PoliceParkingManager : IPoliceParkingManager
    {
        private readonly Repository.Police.IsecurityParkingManager policeParkingRepo;

        public PoliceParkingManager(Repository.Police.IsecurityParkingManager policeParkingRepo)
        {
            this.policeParkingRepo = policeParkingRepo;
        }
        public Task<int> PoliceParking(ParkingModel vehicle)
        {
            return this.policeParkingRepo.Parking(vehicle);
        }

        public double PoliceUnparking(int slotNumber)
        {
            return this.policeParkingRepo.Unparking(slotNumber);
        }
    }
}
