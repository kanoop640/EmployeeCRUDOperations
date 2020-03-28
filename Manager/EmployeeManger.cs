﻿using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class EmployeeManger :IEmployeeManger
    {
        private readonly IEmployeeRepository repo;

        public EmployeeManger(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }

        public Employee DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }
    }
}
