string name = "Ewa";
string sex = "kobieta";
int age = 28;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}
else
{
    Console.WriteLine("Brak osób spełniających warunki.");
}