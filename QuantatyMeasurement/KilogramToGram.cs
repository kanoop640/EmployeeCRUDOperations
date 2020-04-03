// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KilogramToGram.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantatyMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class KilogramToGram
    {
        /// <summary>
        /// Checking the equality of Kilogram and gram
        /// </summary>
        /// <param name="kilogram"></param>
        /// <param name="gram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Kilogram_To_Gram(Kilogram kilogram,Gram gram)
        {
            var value = kilogram.GetValue() * 1000;
            if (gram.GetValue() == value)
            {
                return true;
            }
            return false;
        }
    }
}
