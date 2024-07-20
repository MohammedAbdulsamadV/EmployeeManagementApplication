using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class ExecutiveEmployee : SalariedEmployee
    {
        public double Bonus { get; private set; }
        public ExecutiveEmployee(int employeeID, string Name, Department department, string Phone, string Email, string socialSecurityNumber, double salary , double Bonus) : base(employeeID, Name, department,Phone, Email, socialSecurityNumber, salary)
        {
            this.Bonus = Bonus;
        }

        public void AddBonus(double bonus)
        {
            Bonus +=  bonus;
        }
        public override double Pay()
        {
            return Salary + Bonus;
        }
        public override string Print() => $"ID : {employeeID} " + $"Name : {Name} " + $"{department.Print()} " + $"Phone : {Phone} " + $"Email : {Email} " +
                                          $"SocialSecurityNumber : {socialSecurityNumber} " +
                                          $"Bonus : {Bonus} " + $"Pay : {Pay()}";

    }
}
