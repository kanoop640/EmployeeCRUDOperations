using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Driver
{
    public interface IDriverParkingRepo
    {
        Task<int> DriverParking(ParkingModel parkingModel);
        double DriverUnparking(int slotNumber);
    }
}
