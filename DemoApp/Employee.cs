using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public decimal Salary { get; set; } = 0M;

        public override string ToString()
        {
            return $"{FirstName} {LastName} works in Department {DeptName} and has a salary of {Salary:c}";
        }
    }
}
