// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDBContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.Context
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This class for Creating database type of Employee
    /// </summary>
    public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        /// <summary>
        /// This method create database
        /// </summary>
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
