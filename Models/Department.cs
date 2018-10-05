using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CODEFIRST.Models
{
    [Table(name: "HelloGuys")]

    public class Department

    {

        [Key]

        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }



    }
}