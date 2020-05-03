using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingManager.Manager.Security
{
    public interface ISecurityParkingManager
    {
        Task<int> SecurityParking(ParkingModel parkingModel);
        double SecurityUnparking(int slotNumber);
    }
}
