namespace PolyPayroll_1
{
	internal interface IPayable
	{
		public decimal GetPayableAmount();
	}

	public enum PayrollType
	{
		Salaried,
		Hourly,
		Invoice
	}

}
