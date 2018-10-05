using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CODEFIRST.Models
{
    public class EmployeeDbContext : DbContext

    {

        public EmployeeDbContext() : base("EmployeeDbContext")

        {



        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}