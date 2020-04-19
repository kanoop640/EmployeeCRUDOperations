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
        public Gram(double gram)
        {
            this.gram = gram;
        }
        public double GetValue()
        {
            return this.gram;
        }
    }
}
