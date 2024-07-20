using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Volunteer : StaffMember
    {
        private double Amount;
        public Volunteer(int employeeID, string Name, Department department,string Phone, string Email, double Amount) : base(employeeID, Name, department,Phone, Email)
        {
            this.Amount = Amount;
        }

        public override double Pay()
        {
            return Amount;
        }

        public override string Print()
        {
            return $"ID : {employeeID} " + $"Name : {Name} " + $"{department.Print()} " + $"Phone : {Phone} " + $"Email : {Email} " + $"Amount : {Amount}";
        }
    }
}
