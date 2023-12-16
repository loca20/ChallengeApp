using ChallengeApp;

var employee = new Employee("Damian", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade("3");
employee.AddGrade(7);
employee.AddGrade("osiem");
employee.AddGrade(102);
employee.AddGrade("dwa");
employee.AddGrade(4);


var statistics = employee.GetStatistics();
var counterIncorectGradeValue = employee.GetAddGradeCounter();
var counterAllGrades = counterIncorectGradeValue + statistics.Counter;

Console.WriteLine($"\nAdded {counterAllGrades} grades. {counterIncorectGradeValue} of them have an incorrect value, so the statistics were calculated based on {statistics.Counter} grades:");
Console.WriteLine($"- average: {statistics.Average:N2}");
Console.WriteLine($"- min: {statistics.Min}");
Console.WriteLine($"- max: {statistics.Max}");

