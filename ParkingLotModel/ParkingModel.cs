// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Model.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ParkingLotModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;
    public class ParkingModel
    {
        int id;
        string slotNumber;
        double ratePerHour;
        DateTime checkIn;
        DateTime checkOut;
        string vehicleNumber;
        string parkingType;
        string driverType;
        string vehicleColor;
        string vehicleModel;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
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
        public string ParkingType
        {
            get { return parkingType; }
            set { parkingType = value; }
        }
        public string DriverType
        {
            get { return driverType; }
            set { driverType = value; }
        }
        public string VehicleColor
        {
            get { return vehicleColor; }
            set { vehicleColor = value; }
        }
        public string VehicleModel
        {
            get { return vehicleModel; }
            set { vehicleModel = value; }
        }
    }
}
