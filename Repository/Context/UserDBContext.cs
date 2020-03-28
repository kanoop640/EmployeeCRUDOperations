using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
