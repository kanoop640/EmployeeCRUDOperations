// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inches.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Inches
    {
        /// <summary>
        /// inch variable
        /// </summary>
        int inch;
        /// <summary>
        /// constructor of set value of inch variable
        /// </summary>
        /// <param name="inch"></param>
        public Inches(int inch)
        {
            this.inch = inch;
        }
        /// <summary>
        /// Getting value of inch
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            return this.inch;
        }
        /// <summary>
        /// Checking object equality of null type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || !this.inch.GetType().Equals(obj.GetType()))
                return false;
            else
                return true;
        }
         /// <summary>
         /// This method for checking Inche value are equal or not
         /// </summary>
         /// <param name="inches"></param>
         /// <returns></returns>
        public bool? Cheking_Inch_Values_Equality(Inches inches)
        {
            if (this.inch.Equals(inches.inch))
                return true;
            else
                return false;
        }
    }
}
