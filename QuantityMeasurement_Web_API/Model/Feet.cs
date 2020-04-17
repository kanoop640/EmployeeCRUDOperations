// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurement_Web_API.Model
{
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
        /// <summary>
        /// Overring Equals method and checking value type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !this.feet.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Checking reference value of feet
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public bool CheckingEqualityOfFeetTypeValue(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            else
                return false;
        }
    }
}
