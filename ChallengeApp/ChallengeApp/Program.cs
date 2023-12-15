using ChallengeApp;
using System.Runtime.CompilerServices;

var employee = new Employee("Damian", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade("3");
employee.AddGrade(7);
employee.AddGrade("osiem");
employee.AddGrade(102);

var statistics = employee.GetStatistics();

Console.WriteLine($"\nStatistics were calculated based on {statistics.Counter} grades.");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
