using System.Globalization;

namespace PolyPayroll_1
{
	internal class Salaried_Employee : Employee
	{
		private decimal _WeeklySalary;

		public Salaried_Employee(string firstName, string lastName, string SSN, decimal weeklySalary) 
			: base(firstName, lastName, SSN, PayrollType.Salaried)
		{
			_WeeklySalary= weeklySalary;
		}

		public override decimal GetPayableAmount()
		{
			// Will this handle multiple quantity of weeks?
			return _WeeklySalary;
		}

		public override string ToString()
		{
			string message = base.ToString()
				+ "Weekly Salary: " + _WeeklySalary.ToString("C", CultureInfo.CurrentCulture) + "\n"
				+ "Earned:        " + GetPayableAmount().ToString("C", CultureInfo.CurrentCulture)
				+ "\n";

			return message;
		}

	}
}
