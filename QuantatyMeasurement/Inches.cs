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
    }
}
