// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KilogramToGramUnitTest.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantatyMeasurement;
    using System;
    using System.Collections.Generic;
    using System.Text;
    class KilogramToGramUnitTest
    {
        /// <summary>
        /// This Test case is checking that 1gram is equal to 1gram
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Gram()
        {
            var gram1 = new Gram(1);
            var gram2 = new Gram(1);
            Assert.IsTrue(gram1.GetValue().Equals(gram2.GetValue()));

        }
    
    }
}
