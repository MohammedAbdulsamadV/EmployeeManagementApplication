using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    abstract class Employee : StaffMember
    {
        protected string socialSecurityNumber { get; }
        protected Employee(int employeeID, string Name,Department department ,string Phone, string Email ,string socialSecurityNumber) : base(employeeID,Name,department, Phone, Email)
        {
            this.socialSecurityNumber = socialSecurityNumber;
        }

       


    }
}
