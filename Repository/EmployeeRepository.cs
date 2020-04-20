// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Anoop kumar"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository
{
    using Model;
    using Repository.Context;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class EmployeeRepository :IEmployeeRepository
    {
        private readonly UserDBContext userDBContext;

        public EmployeeRepository(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        /// <summary>
        /// It is adding the employee in the data base
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Employee employee)
        {
            userDBContext.Employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// It is for deleting the employee from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDBContext.Employees.Find(id);
            if (employee != null)
            {
                userDBContext.Employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;

        }
        /// <summary>
        /// This method for getting all the employee form database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDBContext.Employees;
        }
        /// <summary>
        /// Get single employee by giving their id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }
        /// <summary>
        /// This method for updating employee details
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// Login for employee with email and password
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginEmployee(string email,string password)
        {
            var result = userDBContext.Employees.Where(id => id.Email == email && id.Password == password).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
