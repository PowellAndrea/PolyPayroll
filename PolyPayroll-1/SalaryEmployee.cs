using System.Globalization;

namespace PolyPayroll_1
{
	public class SalaryEmployee : Employee
	{
		private decimal _WeeklySalary;

		public override decimal Earnings()
		{
			return _WeeklySalary;
		}

		public SalaryEmployee(string firstName, string lastName, string SSN, decimal weeklySalary) 
			: base(firstName, lastName, SSN, PayrollType.Salaried)
		{
			_WeeklySalary= weeklySalary;
		}

		public override string ToString()
		{
			string message = base.ToString()
				+ "Weekly Salary: " + _WeeklySalary.ToString("C", CultureInfo.CurrentCulture) + "\n"
				+ "Earned:        " + Earnings().ToString("C", CultureInfo.CurrentCulture)	+ "\n";
			return message;
		}

	}
}
