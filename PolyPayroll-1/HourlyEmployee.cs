
using System.Globalization;

namespace PolyPayroll_1
{
	public class HourlyEmployee : Employee
	{
		private decimal _HourlyWage;
		private decimal _HoursWorked;

		public HourlyEmployee(string firstName, string lastName, string SSN, decimal hourlyWage, int hoursWorked) :
			base(firstName, lastName, SSN, PayrollType.Hourly)
		{
			_HourlyWage= hourlyWage;
			_HoursWorked= hoursWorked;
		}

		private decimal Earnings()
		{
			return (_HourlyWage * _HoursWorked);
		}

		public override string ToString()
		{
			string message = base.ToString()
				+ "Hourly wage:  " + _HourlyWage.ToString("C", CultureInfo.CurrentCulture) + "\n"
				+ "Hours Worked: " + _HoursWorked + "\n"
				+ "Earnings:     " + Earnings().ToString("C",CultureInfo.CurrentCulture) + "\n";
			return message;
		}

		public override decimal GetPayableAmount()
		{
			return Earnings();
		}
	}
}