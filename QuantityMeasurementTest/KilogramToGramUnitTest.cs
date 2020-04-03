﻿// --------------------------------------------------------------------------------------------------------------------
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
        public void Checking_Equality_Of_Same_Gram_Value()
        {
            var gram1 = new Gram(1);
            var gram2 = new Gram(1);
            Assert.IsTrue(gram1.GetValue().Equals(gram2.GetValue()));

        }
        /// <summary>
        /// This Test case is checking that 1gram is equal to 2gram
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Different_Grams_Value()
        {
            var gram1 = new Gram(1);
            var gram2 = new Gram(2);
            Assert.IsFalse(gram1.GetValue().Equals(gram2.GetValue()));

        }
        /// <summary>
        /// Checking the equality of 1 kilogram and 1000 gram
        /// </summary>
        [Test]
        public void Checking_Equality__Kilogram_And_Same_Equal_Value_Of__Gram()
        {
            Kilogram kilogram = new Kilogram(1);
            Gram gram = new Gram(1000);
            KilogramToGram kilogramToGram = new KilogramToGram();
            Assert.IsTrue(kilogramToGram.Checking_Equality_Kilogram_To_Gram(kilogram, gram));
        }
        /// <summary>
        /// Checking the equality of 1 kilogram and 2000 gram
        /// </summary>
        [Test]
        public void Checking_Equality_Kilogram_And_Diffrent_Equal_Value_Of_Gram()
        {
            Kilogram kilogram = new Kilogram(1);
            Gram gram = new Gram(2000);
            KilogramToGram kilogramToGram = new KilogramToGram();
            Assert.IsFalse(kilogramToGram.Checking_Equality_Kilogram_To_Gram(kilogram, gram));
        }
    }
}