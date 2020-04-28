using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Manager
{
    public interface IPoliceParkingManager
    {
        Task<int> PoliceParking(ParkingModel parkingModel);
        ParkingModel PoliceUnparking(int slotNumber);
        double PoliceParkingCharges(int slotNumber);
    }
}
