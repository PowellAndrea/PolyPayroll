using PolyPayroll_1;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

List<IPayable> Payout = new();
#region Populate with sample data

HourlyEmployee Joe = new("Joe", "Smith", "100-00-0001", 10, 40);
HourlyEmployee Burton = new("Burton", "Waller", "100-00-0002", 20, 40);
HourlyEmployee William = new("William", "Shatner", "100-00-0003", 30, 40);
Payout.AddRange(new[] { Joe, Burton, William });

Salaried_Employee Amber = new("Amber", "Bluefish", "200-00-0001", 1000);
Salaried_Employee Violet = new("Violet", "Strong", "200-00-0002", 2000);
Salaried_Employee Jessica = new("Jessica", "Seezu", "200-00-0003", 3000);
Payout.AddRange(new[] { Amber, Jessica, Violet });

Invoice Thing1 = new("Thing", "This is a red thing.", (decimal)2.0, 2);
Invoice Thing2 = new("Thing", "This is a blue thing.", (decimal)3.0, 3);
Invoice Thing3 = new("Thing", "This is a green thing.", (decimal)10.00, 4);
Payout.AddRange(new[] { Thing1, Thing2, Thing3 });

#endregion

bool Continue = true;

while (Continue)	// Show Menu
{
	Console.WriteLine("Please select from the following:\n"
	+ "1 Pay a Salaried Employee\n"
	+ "2 Pay an Hourly Employee \n"
	+ "3 Pay an Invoice\n"
	+ "4 Show Weekly Payout\n"
	+ "5 End"
	);
	Continue = doStuff(Payout, Continue);
}

static bool doStuff(List<IPayable> Payout, bool Continue)
{
	switch (Console.ReadLine())
	{
		case "1":	// Pay a Salaried Employee
			{
				Payout.Add(PublicInput.paySalaryEmployee());
				break;
			}

		case "2":   // Pay an Hourly Employee
			{
				Payout.Add(PublicInput.payHourlyEmployee());
				break;
			}

		case "3":   // Pay an Invoice
			{	
				Payout.Add(PublicInput.payInvoice());
				break;
			}

		case "4":   // Show Weekly Payout
			{
				decimal weeklyTotal = 0;
				decimal subTotal = 0;
				string message = string.Empty;

				var groupBy = from payable in Payout
								  group payable by payable.GetType() into newGroup
								  //orderby newGroup.Key
								  select newGroup;

				Console.WriteLine("********** Weekly Payout Detail **********\n");
				foreach (var group in groupBy)
				{
					subTotal = 0;
					foreach (var thing in group)
					{
						Console.WriteLine(thing.ToString());
						subTotal += thing.PayableAmount;
					}
					weeklyTotal += subTotal;
					message
						= "\t" + group.Key.Name + ": "
						+ subTotal.ToString("C", CultureInfo.CurrentCulture) +"\n"
						+ message;
				}

				Console.WriteLine("********** Weekly Payout Summary **********\n");
				Console.WriteLine("Total Weekly Payout:  "
					+ weeklyTotal.ToString("C", CultureInfo.CurrentCulture) +"\n"
					+ "Category Breakdown:\n"
					+ message);

				Console.WriteLine("press any key to continue .....\n\n");
				Console.ReadKey();
				break;
			}

		case "5":   // End
			{
				Continue = false;
				break;
			}

		default: break;
	}

	return Continue;
}