// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inches.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Inches
    {
        /// <summary>
        /// inch variable
        /// </summary>
        double inch;
        /// <summary>
        /// constructor of set value of inch variable
        /// </summary>
        /// <param name="inch"></param>
        public Inches(double inch)
        {
            this.inch = inch;
        }
        /// <summary>
        /// Getting value of inch
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return this.inch;
        }
    }
}
