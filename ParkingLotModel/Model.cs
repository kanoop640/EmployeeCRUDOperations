using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotModel
{
    class Model
    {
        int id;
        string slotNumber;
        string ownerName;
        string carModel;
        string carColor;
        double ratePerHour;
        DateTime checkIn;
        DateTime checkOut;
        string vehicleNumber;
        double customerMobNumber;


        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string SlotNumber
        {
            get
            {
                return slotNumber;
            }
            set
            {
                slotNumber = value;
            }
        }
        public string CarModel
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }
        public string CarColor
        {
            get { return carColor; }
            set { carColor = value; }
        }
        public double RatePerHour
        {
            get { return ratePerHour; }
            set { ratePerHour = value; }
        }
        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }
        public double CustomerMobNumber
        {
            get { return customerMobNumber; }
            set { customerMobNumber = value; }
        }
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

    }
}
