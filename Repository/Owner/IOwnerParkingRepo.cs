using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Owner
{
    public interface IOwnerParkingRepo
    {
        Task<int> Ownerparking(ParkingModel parkingModel);
        double OwnerUnparking(int slotNumber);
        IEnumerable<ParkingModel> GetAllVehicle();
    }
}
