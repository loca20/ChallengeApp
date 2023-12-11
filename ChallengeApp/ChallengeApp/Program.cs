using ChallengeApp;

Employee employee1 = new Employee("Damian", "Kowalski", 24);
Employee employee2 = new Employee("Karol", "Iksiński", 36);
Employee employee3 = new Employee("Jan", "Jankowski", 18);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(3);

employee2.AddScore(8);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(6);
employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(3);
employee3.AddScore(4);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

var maxResult = 0;
Employee employeeWithMaxResult = null;

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3 
};

foreach (var employee in employees)
{
if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Zwycięzcą został " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " 
    + employeeWithMaxResult.Age + " lat zdobywając punktów: " + maxResult);
Console.WriteLine("\nLista wszystkich uczestników konkursu:");
Console.WriteLine("- " + employee1.Name + " " + employee1.Surname + " zdobył punktów: " + result1);
Console.WriteLine("- " + employee2.Name + " " + employee2.Surname + " zdobył punktów: " + result2);
Console.WriteLine("- " + employee3.Name + " " + employee3.Surname + " zdobył punktów: " + result3);


