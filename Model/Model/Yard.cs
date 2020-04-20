// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Yard.cs" company="Bridgelabz">
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
    public class Yard
    {
        double yard;
        public Yard(double yard)
        {
            this.yard = yard;
        }
        public double GetValue()
        {
            return this.yard;
        }
    }
}
