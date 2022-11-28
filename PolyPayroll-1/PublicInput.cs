// using "super spiffy encryption & authentication stuff";

namespace PolyPayroll_1
{
	public class PublicInput
	{

		public static SalaryEmployee paySalaryEmployee()
		{
			SalaryEmployee newPayable;

			Console.WriteLine("First Name:\t");
			string FirstName = Console.ReadLine();
			
			Console.WriteLine("Last Name:\t");
			string LastName = Console.ReadLine();
			
			Console.WriteLine("SSN:\t\t");
			string SSN = Console.ReadLine();
			
			Console.WriteLine("Weekly Salary:\t");
			decimal weeklySalary = Decimal.Parse(Console.ReadLine());

			newPayable = new SalaryEmployee(FirstName,LastName,SSN,weeklySalary);
			
			return newPayable;

		}

		public static HourlyEmployee payHourlyEmployee()
		{
			HourlyEmployee newPayable;

			Console.WriteLine("First Name:\t");
			string FirstName = Console.ReadLine();
			Console.WriteLine("Last Name:\t");
			string LastName = Console.ReadLine();
			Console.WriteLine("SSN:\t\t");
			string SSN = Console.ReadLine();
			Console.WriteLine("Hourly Wage:\t");
			decimal HourlyWage = Decimal.Parse(Console.ReadLine());
			Console.WriteLine("Hours Worked:\t");
			// Should add better error checking here
			int HoursWorked = int.Parse(Console.ReadLine());
			
			newPayable = new HourlyEmployee(FirstName, LastName, SSN, HourlyWage, HoursWorked);
			return newPayable;
		}

		public static Invoice payInvoice()
		{
			//Invoice newPayable;

			Console.WriteLine("Enter part number:\t");
			string partNumber = Console.ReadLine();

			Console.WriteLine("\nEnter part description:\t");
			string partDescription = Console.ReadLine();

			Console.WriteLine("\nEnter price:\t");
			decimal price = Decimal.Parse(Console.ReadLine());

			Console.WriteLine("\nEntery Quantity");
			int quantity = int.Parse(Console.ReadLine());

			Invoice newPayable = new Invoice(partNumber, partDescription, price, quantity);
			return newPayable;
		}
	}
}
