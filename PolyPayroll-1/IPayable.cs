namespace PolyPayroll_1
{
	internal interface IPayable
	{
		public decimal PayableAmount { get; }
	
		// I really thought about requiring an IPayable to have a defined PayrollType.
		// In the end I had the Employee class require the children to define it,
		// but then I also hard coded it into the Invoice class.
		// I would rethink this on the next iteration
	}

	public enum PayrollType
	{
		Salaried,
		Hourly,
		Invoice
	}

}
