using System.Globalization;

namespace PolyPayroll_1
{
	public class Invoice : IPayable
	{
		private string _InvoiceID { get; }
		private string _PartNumber { get;}
		private int		_Quantity { get;}
		private string _PartDescription { get;}
		private decimal _Price { get;}

		public Invoice(string partNumber, string partDescription, decimal price, int quantity)
		{
			_PartNumber = partNumber;
			_PartDescription	= partDescription;
			_Price = price;
			_Quantity = quantity;
			_InvoiceID = new Random().Next(100000, 900000) + "_" + _PartNumber;
		}

		public decimal PayableAmount => _Price * _Quantity;

		public override string ToString()
		{
			string message = "Invoice: " + _InvoiceID + "\n"
				+ "Quantity:		 " + _Quantity + "\n"
				+ "Description:    " + _PartDescription + "\n"
				+ "Unit Price:     " + _Price.ToString("C", CultureInfo.CurrentCulture) + "\n"
				+ "Extended Price: " + PayableAmount.ToString("C",CultureInfo.CurrentCulture) +"\n";
			return message;
		}
	}
}
