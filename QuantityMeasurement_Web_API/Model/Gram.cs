// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gram.cs" company="Bridgelabz">
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
    public class Gram
    {
        /// <summary>
        /// Variable for gram value
        /// </summary>
        double gram;
        public Gram(int gram)
        {
            this.gram = gram;
        }
        public double GetValue()
        {
            return this.gram;
        }
        /// <summary>
        /// This method is checking the gram equality
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Grams(Gram gram)
        {
            if (this.gram == gram.GetValue())
            {
                return true;
            }
            return false;
        }
    }
}
