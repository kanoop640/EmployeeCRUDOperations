// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feet.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Feet
    {
        /// <summary>
        /// feet variable
        /// </summary>
        int feet;                                         
         /// <summary>
         /// constructor for setting the value of feet
         /// </summary>
         /// <param name="feet"></param>
        public Feet(int feet)
        {
            this.feet = feet;
        }
        /// <summary>
        /// Getting the value of feet
        /// </summary>
        /// <returns></returns>
        public int GetValue()
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
        public bool ConverteToFeet(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            else
                return false;
        }
    }
    
}
