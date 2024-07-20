using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class SalariedEmployee : Employee
    {
        public double Salary { get;  }
        public SalariedEmployee(int employeeID, string Name,Department department ,string Phone, string Email, string socialSecurityNumber, double salary) : base(employeeID, Name,department ,Phone, Email, socialSecurityNumber)
        {
            Salary = salary;
        }
       

        public override double Pay()
        {
            return Salary;
        }

        public override string Print() =>  $"ID : {employeeID} " + $"Name : {Name} " + $"{department.Print()} " + $"Phone : {Phone} " + $"Email : {Email} "
            + $"SocialSecurityNumber : {socialSecurityNumber} " + $"Pay : {Pay()}";
    }
}
