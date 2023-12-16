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

var statistics = employee.GetStatisticsWithForEach();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();

var correctGradeCounter = employee.GradesCount;
var counterAllGrades = employee.IncorrectGradeCounter + correctGradeCounter;

Console.WriteLine($"\nAdded {counterAllGrades} grades. {employee.IncorrectGradeCounter} of them have an incorrect value, so the statistics were calculated based on {correctGradeCounter} grades:");
Console.WriteLine($"- average: {statistics.Average:N2}");
Console.WriteLine($"- min: {statistics.Min}");
Console.WriteLine($"- max: {statistics.Max}");