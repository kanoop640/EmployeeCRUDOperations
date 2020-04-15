// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// It is interface for creating method 
    /// </summary>
    public interface IEmployeeRepository

    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employeeChanges);
        Employee DeleteEmployee(int id);
        bool LoginEmployee(string email, string password);
    }
}
