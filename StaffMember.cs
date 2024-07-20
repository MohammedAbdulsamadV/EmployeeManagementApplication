using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementApplication
{
    abstract class StaffMember
    {
        public int employeeID { get; }
        public string Name { get; }
        public string Phone { get; }
        public string Email { get; }
        public Department department { get; }
        public StaffMember(int employeeID, string Name , Department department, string Phone, string Email) 
        {
            this.Email = Email;
            this.employeeID = employeeID;
            this.Name = Name;
            this.Phone = Phone;
            this.department = department;
        }
        public abstract double Pay();

        //public override bool Equals(object? obj)
        //{
        //    if (obj == null) return false;
        //    if (!(obj is StaffMember))
        //    {
        //        return false;
        //    }
        //    StaffMember other = (StaffMember)obj;
        //    return this.employeeID == other.employeeID && this.Name == other.Name && this.Phone == other.Phone && this.Email == other.Email;
        //}

        public abstract string Print();
       


    }
}
