using PolyPayroll_1;

#region Populate with sample data
HourlyEmployee Joe = new("Joe", "Smith", "100-00-0001", 10, 40);
HourlyEmployee Burton = new("Burton", "Waller", "100-00-0002", 20, 40);
HourlyEmployee William = new("William", "Shatner", "100-00-0003", 30, 40);

Salaried_Employee Amber = new("Amber", "Bluefish", "200-00-0001", 1000);
Salaried_Employee Violet = new("Violet", "Strong", "200-00-0002", 2000);
Salaried_Employee Jessica = new("Jessica", "Seezu", "200-00-0003", 3000);

Invoice Thing1 = new("Thing", "This is a red thing.", (decimal)2.0, 2);
Invoice Thing2 = new("Thing", "This is a blue thing.", (decimal)3.0, 3);
Invoice Thing3 = new("Thing", "This is a green thing.", (decimal)10.00, 4);

Console.WriteLine(Joe.ToString());
Console.WriteLine(Burton.ToString());
Console.WriteLine(William.ToString());

Console.WriteLine(Amber.ToString());
Console.WriteLine(Violet.ToString());
Console.WriteLine(Jessica.ToString());

Console.WriteLine(Thing1.ToString());
Console.WriteLine(Thing2.ToString());
Console.WriteLine(Thing3.ToString());
#endregion

#region Show Menu





#endregion
