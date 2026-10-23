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
DateTime? resignationDate = new DateTime(2026, 10, 1);

if (resignationDate.HasValue && resignationDate.Value.Date <= DateTime.Today)
{
	Console.WriteLine("Your Last working date "+resignationDate.Value.ToString("dd-MM-yyyy"));
}
else
{
	Console.WriteLine("Employee is currently working.");
}