using ChallengeApp;

Console.WriteLine("Witamy w programie POP (Program Oceny Pracowników).");
Console.WriteLine("============================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika: ");

var employee = new Employee("Jan", "Kowalski");

while (true)
{

    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    Console.WriteLine("Podaj kolejną ocenę pracownika lub wciśnij 'Q'aby wyświetlić statystyki: ");
}

var statistics = employee.GetStatistics();
var correctGradeCounter = employee.GradesCount;
var counterAllGrades = employee.IncorrectGradeCounter + correctGradeCounter;

if (employee.IncorrectGradeCounter == 0)
{
    Console.WriteLine($"\nStatystyka została policzona na podstawie {correctGradeCounter} poprawnie dodanych ocen:");

}
else
{
    Console.WriteLine($"\nIlość dodanych ocen: {counterAllGrades}. {employee.IncorrectGradeCounter} z nich ma niepoprawną wartość, dlatego statystyki zostały policzone na podstawie {correctGradeCounter} poprawnie dodanych ocen:");

}
Console.WriteLine($"- średnia ocen: {statistics.Average} ({statistics.AverageLetter})");
Console.WriteLine($"- ocena najniższa: {statistics.Min}");
Console.WriteLine($"- ocena najwyższa: {statistics.Max}");