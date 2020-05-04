using ParkingLotModel;
using Repository.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Manager.Security
{
    public class SecurityParkingManger : ISecurityParkingManager
    {
        private readonly ISecurityParkingRopo securityParkingRopo;

        public SecurityParkingManger(ISecurityParkingRopo securityParkingRopo)
        {
            this.securityParkingRopo = securityParkingRopo;
        }

        public Task<int> SecurityParking(ParkingModel parkingModel)
        {
            return securityParkingRopo.SecurityParking(parkingModel);
        }

        public double SecurityUnparking(int id)
        {
            return securityParkingRopo.SecurityUnparking(id);
        }
    }
}
