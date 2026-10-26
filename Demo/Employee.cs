using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public Department Department { get; set; }

		private decimal basicSalary;

		public Employee(int employeeId, string employeeName, Department department, decimal salary)
		{
			EmployeeId = employeeId;
			EmployeeName = employeeName;
			Department = department;
			basicSalary = salary;
		}

		public decimal GetBasicSalary()
		{
			return basicSalary;
		}
	}
}
