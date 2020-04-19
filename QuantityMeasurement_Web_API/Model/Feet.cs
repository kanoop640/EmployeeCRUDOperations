// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurement_Web_API.Model
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Feet
    {
        /// <summary>
        /// feet variable
        /// </summary>
        double feet;

        /// <summary>
        /// constructor for setting the value of feet
        /// </summary>
        /// <param name="feet"></param>
        public Feet(double feet)
        {                                                                                      
            this.feet = feet;
        }

        /// <summary>
        /// Getting the value of feet
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return this.feet;
        }
    }
}
