//Console.WriteLine("Hello, World!");
//int x = Console.Read();
//int y = Console.Read();
//int z = x + y;

//string employeeName = "Jawahar";
//string department = "Development";

//Console.WriteLine(employeeName);
//Console.WriteLine(department);
//Console.WriteLine(employeeName + " - " + department);
//Console.WriteLine($"Employee: {employeeName}, Department: {department}");
//Console.WriteLine(employeeName.Length);
//Console.WriteLine(employeeName.ToUpper());

//int basicSalary = 30000;
//decimal allowance = 5000.50m;
//decimal totalSalary = basicSalary + allowance;

//Console.WriteLine($"Total Salary: {totalSalary}");
//Console.WriteLine(z);
//Console.Write("Enter joining date (yyyy-MM-dd): ");
//DateTime joiningDate = DateTime.Parse(Console.ReadLine()!);
//DateTime today = DateTime.Today;

//Console.WriteLine(joiningDate.ToString("dd-MM-yyyy"));
//Console.WriteLine(today.ToString("dd-MM-yyyy"));

//int daysWorked = (today - joiningDate).Days;
//Console.WriteLine($"Days since joining: {daysWorked}");

//int years = DateTime.Today.Year - joiningDate.Year;

//if (DateTime.Today < joiningDate.AddYears(years))
//{
//	years--;
//}

//Console.WriteLine("Years worked: " + years);
//DateTime? resignationDate = new DateTime(2026, 10, 1);

//if (resignationDate.HasValue && resignationDate.Value.Date <= DateTime.Today)
//{
//	Console.WriteLine("Your Last working date "+resignationDate.Value.ToString("dd-MM-yyyy"));
//}
//else
//{
//	Console.WriteLine("Employee is currently working.");
//}

//static decimal salaryno(decimal n)
//{
//	return n * 12;
//}


//decimal a = salaryno(35503);
//Console.Write("Your Salary for the Year is " + a);

//static bool IsValidAge(int age)
//{
//	if (age >= 18 && age <= 60)
//	{
//		 Console.WriteLine("Your Age ok");
//		return true;
//	}

//	return false;
//}

//Console.WriteLine(IsValidAge(25));

//static string GetEmployeeType(int code)
//{
//	switch (code)
//	{
//		case 1:
//			return "Permanent";
//		case 2:
//			return "Contract";
//		case 3:
//			return "Intern";
//		default:
//			return "Invalid employee type";
//	}
//}

//Console.WriteLine(GetEmployeeType(2));

//for (int i = 5; i >= 1; i--)
//{
//	for (int j = 1; j <= 5-i; j++)
//	{
//		Console.Write(" ");
//	}
//	for (int j = 1; j <= 2 * i - 1; j++)
//	{
//		Console.Write("*");
//	}
//	Console.WriteLine();
//}
using Demo;

Department department = new Department(1, "Development");

Employee employee = new Employee(
	101,
	"Jawahar",
	department,
	30000m
);

SalaryComponent hra = new SalaryComponent("HRA", 5000m);

Console.WriteLine($"Employee ID: {employee.EmployeeId}");
Console.WriteLine($"Employee Name: {employee.EmployeeName}");
Console.WriteLine($"Department: {employee.Department.DepartmentName}");
Console.WriteLine($"Basic Salary: {employee.GetBasicSalary()}");
Console.WriteLine($"{hra.ComponentName}: {hra.Amount}");