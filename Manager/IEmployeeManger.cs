// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManger.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// It is Interface of type for creating the method of 
    /// Employee type and perform operations
    /// </summary>
    public interface IEmployeeManger
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
    }
}
