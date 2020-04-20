// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Fahranheit.cs" company="Bridgelabz">
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
    public class Fahranheit
    {
        double fahrenheit;
        public Fahranheit(double fahranheit)
        {
            this.fahrenheit = fahranheit;
        }
        public double GetValue()
        {
            return this.fahrenheit;
        }
    }
}
