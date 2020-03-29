// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeManger.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager
{
    using Model;
    using Repository;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// This class implements the method of IEmployeeManager Class
    /// </summary>
    public class EmployeeManger :IEmployeeManger
    {
        private readonly IEmployeeRepository repo;

        public EmployeeManger(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        /// <summary>
        /// This method for Adding employee in the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }
        /// <summary>
        /// This method for deleting the employee by giving the Employee Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }
        /// <summary>
        /// This method for getting all employee form database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }
        /// <summary>
        /// Get single Employee by giving their Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }
        /// <summary>
        /// For updating the employee details
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }
    }
}
