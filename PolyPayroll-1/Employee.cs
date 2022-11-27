﻿namespace PolyPayroll_1
{
	public abstract class Employee
	{
		private string _FirstName { get; }
		private string _LastName { get; }
		private string _SSN { get; }
		private PayrollType _Type { get; }

		readonly decimal PayableAmount;

		public Employee(string firstName, string lastName, string SSN, PayrollType type)
		{
			_FirstName = firstName;
			_LastName = lastName;
			_SSN = SSN;
			_Type = type;
		}

		public override string ToString()
		{
			string message = _Type
				+ " employee: " + _FirstName + " " + _LastName + "\n"
				+ "SSN: " + _SSN + "\n";
			return message;
		}
	}
}