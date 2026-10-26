using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string DepartmentName { get; set; }

		public Department(int departmentId, string departmentName)
		{
			DepartmentId = departmentId;
			DepartmentName = departmentName;
		}
	}
}
