namespace PolyPayroll_1
{
	internal interface IPayable
	{
		public decimal PayableAmount { get; }
	}

	public enum PayrollType
	{
		Salaried,
		Hourly,
		Invoice
	}

}
