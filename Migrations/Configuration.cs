namespace MVC_CODEFIRST.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_CODEFIRST.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(MVC_CODEFIRST.Models.EmployeeDbContext context)

        {

            var departments = new List<Department>

      {

        new Department { DepartmentName = "Electrical Department" },

        new Department { DepartmentName = "Civil Department" },

        new Department { DepartmentName = "Bio Science department" }

      };

            departments.ForEach(x => context.Departments.Add(x));

            context.SaveChanges();

            var employees = new List<Employee>

      {

        new Employee { Name = "peter", Age = 25, DepartmentID = 1 },

        new Employee { Name = "John", Age = 25, DepartmentID = 2 },

        new Employee { Name = "Chandan", Age = 26, DepartmentID = 3 },

        new Employee { Name = "Debanjan", Age = 24, DepartmentID = 1 },

        new Employee { Name = "Akhil", Age = 22, DepartmentID = 1 },

        new Employee { Name = "Vikram", Age = 24, DepartmentID = 2 }

      };

            employees.ForEach(x => context.Employees.Add(x));

            context.SaveChanges();

            // This method will be called after migrating to the latest version.



            // You can use the DbSet<T>.AddOrUpdate() helper extension method 

            // to avoid creating duplicate seed data. E.g.

            //

            //  context.People.AddOrUpdate(

            //   p => p.FullName,

            //   new Person { FullName = "Andrew Peters" },

            //   new Person { FullName = "Brice Lambson" },

            //   new Person { FullName = "Rowan Miller" }

            //  );

            //

        }

    }


}