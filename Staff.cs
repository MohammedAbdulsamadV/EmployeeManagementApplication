using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Staff
    {
        public static List<StaffMember> Members = new List<StaffMember>();
        public static void CalcPayRoll()
        {
            double sum = 0;
            foreach (var item in Members)
            {
                sum += item.Pay();
            }
            Console.WriteLine($"The Total Salaries of All Employees : {sum}");
        }
        public static void AddMember()
        {
            Console.WriteLine("1 - Salaried Employee ");
            Console.WriteLine("2 - Hourly Employee ");
            Console.WriteLine("3 - Commision Employee ");
            Console.WriteLine("4 - Executive Employee ");
            Console.WriteLine("5 - Volunteer ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                AddSalariedEmployee();
               
            }
            else if (choice == 2)
            {
                AddHourlyEmployee();
            }
            else if (choice == 3)
            {
                AddCommisionEmployee();

            }
            else if (choice == 4)
            {
                AddExecutiveEmployee();

            }
            else if (choice == 5)
            {
                AddVolunteer();

            }
            else
            {
                Console.WriteLine("Invalid");
                AddMember();
            }


        }
        public static int Count => Members.Count;

        #region Adding

        private static void AddSalariedEmployee()
        {
            Console.WriteLine("Enter Member ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name : ");
            string memName = Console.ReadLine();
            Console.WriteLine("Enter Phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department ID : ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptID, deptName);
            Console.WriteLine("Enter SocialSecurityNumber : ");
            string socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            double salary = double.Parse(Console.ReadLine());
            SalariedEmployee employee = new SalariedEmployee(ID, memName, dept, phone, email, socialSecurityNumber, salary);
            Members.Add(employee);
        }
        private static void AddHourlyEmployee()
        {
            Console.WriteLine("Enter Member ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name : ");
            string memName = Console.ReadLine();
            Console.WriteLine("Enter Phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department ID : ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptID, deptName);
            Console.WriteLine("Enter SocialSecurityNumber : ");
            string socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter Hours Worked : ");
            int hoursWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate : ");
            int Rate = int.Parse(Console.ReadLine());
            HourlyEmployee employee = new HourlyEmployee(ID, memName, dept, phone, email, socialSecurityNumber, hoursWorked, Rate);
            Members.Add(employee);
        }
        private static void AddCommisionEmployee()
        {
            Console.WriteLine("Enter Member ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name : ");
            string memName = Console.ReadLine();
            Console.WriteLine("Enter Phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department ID : ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptID, deptName);
            Console.WriteLine("Enter SocialSecurityNumber : ");
            string socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter Target : ");
            double target = int.Parse(Console.ReadLine());
            CommisionEmployee employee = new CommisionEmployee(ID, memName, dept, phone, email, socialSecurityNumber, target);
            Members.Add(employee);
        }
        private static void AddExecutiveEmployee()
        {
            Console.WriteLine("Enter Member ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name : ");
            string memName = Console.ReadLine();
            Console.WriteLine("Enter Phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department ID : ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptID, deptName);
            Console.WriteLine("Enter SocialSecurityNumber : ");
            string socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bonus : ");
            double bonus = double.Parse(Console.ReadLine());
            ExecutiveEmployee employee = new ExecutiveEmployee(ID, memName, dept, phone, email, socialSecurityNumber, salary, bonus);
            Members.Add(employee);
        }
        private static void AddVolunteer()
        {
            Console.WriteLine("Enter Member ID : ");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name : ");
            string memName = Console.ReadLine();
            Console.WriteLine("Enter Phone : ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Department ID : ");
            int deptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptID, deptName);
            Console.WriteLine("Enter SocialSecurityNumber : ");
            string socialSecurityNumber = Console.ReadLine();
            Console.WriteLine("Enter Hours Worked : ");
            int hoursWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount : ");
            double amount = double.Parse(Console.ReadLine());
            Volunteer volunteer = new Volunteer(ID, memName, dept, phone, email, amount);
            Members.Add(volunteer);
        }

        #endregion
        public static void DeleteMember(int _id)
        {
            foreach (var item in Members)
            {
                if (item.employeeID == _id)
                {
                    Members.Remove(item);
                }
            }

        }

        public static void UpdateMember(int _id)
        {
            foreach (var item in Members)
            {
                if (item.employeeID == _id)
                {
                    Members.Remove(item);
                }
            }
            AddMember();
        }

        public static void Search(int _id)
        {
            foreach (var item in Members)
            {
                if (item.employeeID == _id)
                {
                    item.Print();
                    Console.WriteLine("===========================");
                }
            }
           
        }
        public static void ShowAll()
        {
            foreach (var item in Members)
            {
                Console.WriteLine("=======================");
                Console.WriteLine(item.Print());
                Console.WriteLine("=======================");
            }
        }

    }
}
