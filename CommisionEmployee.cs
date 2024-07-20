using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class CommisionEmployee : Employee
    {
        public double Target { get;  }
        public CommisionEmployee(int employeeID, string Name,Department department ,string Phone, string Email, string socialSecurityNumber, double target) : base(employeeID, Name,department, Phone, Email, socialSecurityNumber)
        {
            Target = target;
        }
        public override double Pay()
        {
            return 0.05 * Target;
        }

        public override string Print() => $"ID : {employeeID} " + $"Name : {Name} " + $"{department.Print()} " + $"Phone : {Phone} " + $"Email : {Email} " + $"SocialSecurityNumber : {socialSecurityNumber} " + $"Pay : {Pay()}";
    }
}
