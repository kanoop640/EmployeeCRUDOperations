using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.ParkingLotOwner
{
    public interface IParkingLotOwnerRepo
    {
        IEnumerable<ParkingModel> GetAllVehicle();
        List<ParkingModel> GetAllPoliceTypeVehicle();
        List<ParkingModel> GetAllSecurityTypeVehicle();
        List<ParkingModel> GetAllDriverTypeVehicle();
        List<ParkingModel> GetAllOwnerTypeVehicle();
    }
}
