using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IParkingRepository
    {
        Task<int> Parking(string vehicleNumber, double ratePerHour);
    }
}
