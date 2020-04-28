using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Police
{
    public interface IPoliceParking
    {
        Task<int> Parking(ParkingModel parkingModel);
    }
}
