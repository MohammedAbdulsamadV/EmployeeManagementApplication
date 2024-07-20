using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Project
    {
		public static List<Project> projects = new List<Project>();
		public List<Budget> budgets = new List<Budget>();
		private StaffMember manager;
		public int projectID { get;}
		private string Location;
		private double CurrentCost;
		public Project(int projectId, StaffMember manager, string location, double currentCost)
		{
			this.manager = manager;	
			this.projectID = projectId;
			this.Location = location;
			this.CurrentCost = currentCost;
			Budget budget = new Budget(projectID, CurrentCost);
			budgets.Add(budget);
			
		}
		public static void AddProject()
		{
            Console.WriteLine("Enter Project ID :");
			int pID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager Name :");
			string managerName = Console.ReadLine();
			StaffMember manager = null;

            foreach (var item in Staff.Members)
			{
				if (item.Name == managerName)
				{
					manager = item;
				}
				else
				{
					Console.WriteLine("Invalid Staff Member");
					AddProject();
				}
            }
            Console.WriteLine("Enter Location :");
			string locationName = Console.ReadLine();
            Console.WriteLine("Enter Current Cost :");
            double currentCost = double.Parse(Console.ReadLine());
			Project project = new Project(pID, manager, locationName,currentCost);
			projects.Add(project);

        }
        public void AddBudget(int _budgetId,double Value)
		{
			Budget budget = new Budget(_budgetId, Value);
			budgets.Add(budget);

		} 
		public void GetTotalBudget(double Value)
		{
			double sum = 0;
			foreach (var item in budgets)
			{
				sum += item.value;
			}
            Console.WriteLine($"Total Budget for this project : {sum+Value}");
        }
		
		public void Print() 
		{
			Console.WriteLine($"Project ID : {this.projectID}");
            Console.WriteLine($"Location : {this.Location}");
            Console.WriteLine($"CurrentCost : {this.GetTotalBudget}");
            Console.WriteLine($"Manager : {manager.Print()}");


            foreach (var item in budgets)
            {
				int i = 1;
                Console.WriteLine($"Budget of milestone {i} : {item.value}");
				i++;
            }


        }

    }
}
