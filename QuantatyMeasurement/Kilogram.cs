// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Kilogram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Kilogram
    {
        int kilogram;
        public Kilogram(int kilogram)
        {
            this.kilogram = kilogram;
        }
        public int GetValue()
        {
            return this.kilogram;
        }
    }
}
