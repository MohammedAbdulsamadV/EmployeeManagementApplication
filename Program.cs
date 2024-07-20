namespace EmployeeManagementApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //#region Departments
            //Department Sales = new Department(1, "Sales");
            //Department IT = new Department(2, "IT");
            //Department Finance = new Department(3, "Finance");
            //Department Marketing = new Department(4, "Marketing");
            //#endregion

            //#region StaffMembers
            //SalariedEmployee emp1 = new SalariedEmployee(1, "Mohamed Ali", Sales, "01012359341", "mali@gmail.com", "101020", 7000);
            //SalariedEmployee emp2 = new SalariedEmployee(2, "Mohamed Samir", IT, "01019639347", "msamir@gmail.com", "101021", 24000);

            //HourlyEmployee emp3 = new HourlyEmployee(3, "Eman Ahmed", Marketing, "01023568914", "emanahmed@gmail.com", "101022", 140, 500);
            //HourlyEmployee emp4 = new HourlyEmployee(4, "Sara Adel", Marketing, "01068468259", "saraadel@gmail.com", "101023", 140, 500);

            //CommisionEmployee emp5 = new CommisionEmployee(5, "Hussen Rashed", Finance, "01012684237", "hrashed@gmail.com", "101024", 22000);
            //CommisionEmployee emp6 = new CommisionEmployee(6, "Ahmed Farag", Finance, "01045698237", "afarag@gmail.com", "101025", 10000);

            //ExecutiveEmployee emp7 = new ExecutiveEmployee(7, "Basel Walid", IT, "010357896541", "bwalid@gmail.com", "101026", 50000, 12000);

            //Volunteer vol1 = new Volunteer(8, "Hani Adel", Sales, "01026957458", "hadel@gmail.com", 7000);

            //Staff.Members.Add(emp1);
            //Staff.Members.Add(emp2);
            //Staff.Members.Add(emp3);
            //Staff.Members.Add(emp4);
            //Staff.Members.Add(emp5);
            //Staff.Members.Add(emp6);
            //Staff.Members.Add(emp7);
            //Staff.Members.Add(vol1); 
            //#endregion

            while (true)
            {
                Console.WriteLine("1- Add Employee");
                Console.WriteLine("2- Update");
                Console.WriteLine("3- Delete Employee");
                Console.WriteLine("4- Show PayRoll Of Employees");
                Console.WriteLine("5- Show Info Of All Employees");
                Console.WriteLine("6- Search");
                Console.WriteLine("7- Add Department");
                Console.WriteLine("8- Print All Departments");
                Console.WriteLine("9- Add Project");
                Console.WriteLine("10- Show All Projects");
                Console.WriteLine("11- Add Budget to Existing Project");
                Console.WriteLine("12- Increase Budget to Existing Project");



                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Staff.AddMember();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Staff.UpdateMember(id);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter ID : ");
                    int id = int.Parse(Console.ReadLine());
                    Staff.DeleteMember(id);
                }
                else if (choice == 4)
                {
                    Staff.CalcPayRoll();
                }
                else if (choice == 5)
                {
                    Staff.ShowAll();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Enter ID :");
                    int id = int.Parse(Console.ReadLine());
                    Staff.Search(id);
                }
                else if (choice == 7)
                {
                    Department.AddDept();
                }
                else if (choice == 8)
                {
                    Department.PrintAll();
                }
                else if (choice == 9)
                {
                   Project.AddProject();
                }
                else if(choice == 10)
                {
                    foreach (var item in Project.projects)
                    {
                        item.Print();
                    }
                }
                else if (choice == 11)
                {
                    Console.WriteLine("Enter Project ID : ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Budget ID : ");
                    int bid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Budget Value : ");
                    double value = int.Parse(Console.ReadLine());
                    foreach (var item in Project.projects)
                    {
                        if (item.projectID == pid)
                        {
                            item.AddBudget(bid, value);
                        }
                    }
                }
                else if (choice == 12)
                {
                    Console.WriteLine("Enter Project ID : ");
                    int pid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Budget ID : ");
                    int bid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Budget Value : ");
                    double value = int.Parse(Console.ReadLine());
                    foreach (var item in Project.projects)
                    {
                        if (item.projectID == pid)
                        {
                            foreach (var element in item.budgets)
                            {
                                element.IncreaseBudget(pid, bid, value);
                            }
                        }
                    }
                }
            }




        }
    }
}
