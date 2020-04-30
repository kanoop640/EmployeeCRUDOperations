﻿using ParkingLotModel;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Police
{
    public interface IPoliceParkingRepo
    {
        Task<int> Parking(ParkingModel parkingModel);
        double Unparking(int id);
    }
}