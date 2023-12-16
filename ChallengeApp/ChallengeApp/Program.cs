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

var correctGradeCounter = employee.GradesCount;
var counterAllGrades = employee.IncorrectGradeCounter + correctGradeCounter;

var statistics = employee.GetStatisticsWithForEach();
Console.WriteLine("\nResult for 'foreach' loop:");
Console.WriteLine($"\nAdded {counterAllGrades} grades. {employee.IncorrectGradeCounter} of them have an incorrect value, so the statistics were calculated based on {correctGradeCounter} grades:");
Console.WriteLine($"- average: {statistics.Average:N2}");
Console.WriteLine($"- min: {statistics.Min}");
Console.WriteLine($"- max: {statistics.Max}");

var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine("\nResult for 'for' loop:");
Console.WriteLine($"\nAdded {counterAllGrades} grades. {employee.IncorrectGradeCounter} of them have an incorrect value, so the statistics were calculated based on {correctGradeCounter} grades:");
Console.WriteLine($"- average: {statistics1.Average:N2}");
Console.WriteLine($"- min: {statistics1.Min}");
Console.WriteLine($"- max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("\nResult for 'do while' loop:");
Console.WriteLine($"\nAdded {counterAllGrades} grades. {employee.IncorrectGradeCounter} of them have an incorrect value, so the statistics were calculated based on {correctGradeCounter} grades:");
Console.WriteLine($"- average: {statistics2.Average:N2}");
Console.WriteLine($"- min: {statistics2.Min}");
Console.WriteLine($"- max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("\nResult for 'while' loop:");
Console.WriteLine($"\nAdded {counterAllGrades} grades. {employee.IncorrectGradeCounter} of them have an incorrect value, so the statistics were calculated based on {correctGradeCounter} grades:");
Console.WriteLine($"- average: {statistics3.Average:N2}");
Console.WriteLine($"- min: {statistics3.Min}");
Console.WriteLine($"- max: {statistics3.Max}");