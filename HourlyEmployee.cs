using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class HourlyEmployee : Employee
    {
        public double hoursWorked { get;  }
        public double Rate { get; }
        
        double addedpay = 0;

        public HourlyEmployee(int employeeID, string Name, Department department, string Phone, string Email, string socialSecurityNumber,double hoursWorked, double Rate) : base(employeeID, Name,department ,Phone, Email, socialSecurityNumber)
        {
            this.hoursWorked = hoursWorked;
            this.Rate = Rate;
        }

        public void AddHours(int morehours)
        {
             addedpay = morehours * Rate;
        }

        public override double Pay()
        {  
            return Rate * hoursWorked + addedpay;
        }

        public override string Print() => $"ID : {employeeID} " + $"Name : {Name} " + $"{department.Print()} "+ $"Phone : {Phone} " + $"Email : {Email} " + 
                                          $"SocialSecurityNumber : {socialSecurityNumber} " +
                                          $"HoursWorked : {hoursWorked} " + $"Rate : {Rate} " + $"Pay : {Pay()}";
    }
}
