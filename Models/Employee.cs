using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CODEFIRST.Models
{
    [Table(name: "HelloWorld")]

    public class Employee

    {

        [Key]

        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }



        public int DepartmentID { get; set; }

        public Department Department { get; set; }

    }
}