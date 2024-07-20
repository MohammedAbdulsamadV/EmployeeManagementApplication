using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Department
    {
        public static List<Department> departments = new List<Department>();
        private int departmentID {  get; }
        private string departmentName { get; }
        public Department(int departmentID,string departmentName) {
            this.departmentID = departmentID;
            this.departmentName = departmentName;
           
        }
        public static void PrintAll()
        {
            foreach(Department department in departments)
            {
                Console.WriteLine($"departmentID : {department.departmentID}");
                Console.WriteLine($"departmentName : {department.departmentName}");

            }
        }
        public string Print()
        {
            return $"departmentID : {this.departmentID} " + $"departmentName : {this.departmentName}";
        }
        public static void AddDept()
        {
            Console.WriteLine("Enter Dept ID :");
            int departmentID = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter Dept Name :");
            string departmentName = Console.ReadLine();
            Department dept = new Department(departmentID, departmentName);
            departments.Add(dept);
        }
    }
}
