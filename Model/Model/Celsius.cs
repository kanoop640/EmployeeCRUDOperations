// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Celsius.cs" company="Bridgelabz">
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
    public class Celsius
    {
        double celsius;
        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }
        public double GetValue()
        {
            return this.celsius;
        }
        /// <summary>
        /// Checking the equality of Celsisu value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public bool Cheching_Equality_Of_Celsius_Value(Celsius celsius)
        {
            if (this.celsius == celsius.GetValue())
            {
                return true;
            }
            return false;
        }
    }
}
