using Objektorientering_Klasshierarki;

//Employee hourlyEmployeeWage  = new HourlyEmployeeWage();

List<Employee> employees = new List<Employee>();
Manager manager = new Manager();
manager.Name = "Göran";
manager.WorkingHours = 30;
manager.HourlyWage = 250;

Developer developer = new Developer();
developer.Name = "Klas";
developer.WorkingHours = 56;
developer.HourlyWage = 200;

SalesPerson salesPerson = new SalesPerson();
salesPerson.Name = "Lasse";
salesPerson.WorkingHours = 40;
salesPerson.HourlyWage = 170;

employees.Add(manager);
employees.Add(developer);
employees.Add(salesPerson);

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.CalculateSalary());
}


/*
SalesPerson salesPerson = new SalesPerson();
Developer developer = new Developer();
Manager manager = new Manager();

Console.WriteLine("How many hours did " + salesPerson.name + " work?");
double salesPersonsWorkingHours = double.Parse(Console.ReadLine());
double salesPersonSalary = hourlyEmployeeWage.CalculateSalary(salesPerson.hourlyWage, salesPersonsWorkingHours);
Console.WriteLine(salesPerson.name + "'s salary is equal to: " + salesPersonSalary + " Kr");

Console.WriteLine("How many hours did " + developer.name + " work?");
double developersWorkingHours = double.Parse(Console.ReadLine());
double developerSalary = hourlyEmployeeWage.CalculateSalary(developer.hourlyWage, developersWorkingHours);
Console.WriteLine(developer.name + "'s salary is equal to: " + developerSalary + " Kr");

Console.WriteLine("How many hours did " + manager.name + " work?");
double managersWorkingHours =double.Parse(Console.ReadLine());
double managersSalary = hourlyEmployeeWage.CalculateSalary(manager.hourlyWage, managersWorkingHours);
Console.WriteLine(manager.name + "'s salary is equal to: " + managersSalary + " Kr");
*/