using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Budget
    {
		
		public Budget(int _budgetId,double value) { 
			this.BudgetID = _budgetId;
			this.Value = value;
			
		}
		private int BudgetID;

		public int id
		{
			get { return BudgetID; }
			
		}
		private double Value;

		public double value
		{
			get { return Value; }
			
		}
		public void IncreaseBudget(int _projectId,int _budgetId,double amount)
		{
			foreach (var item in Project.projects)
			{
				if (item.projectID == _projectId && BudgetID == _budgetId)
				{
					Value += amount;
					
				}
			}
		}

	}
}
