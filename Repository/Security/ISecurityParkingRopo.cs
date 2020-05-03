using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Security
{
    public interface ISecurityParking
    {
        Task<int> SecurityParking(ParkingModel parkingModel);
        double SecurityUnparking(int slotNumber);
    }
}
