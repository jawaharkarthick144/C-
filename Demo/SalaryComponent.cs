using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
	public class SalaryComponent
	{
		public string ComponentName { get; set; }
		public decimal Amount { get; set; }

		public SalaryComponent(string componentName, decimal amount)
		{
			ComponentName = componentName;
			Amount = amount;
		}
	}
}
