List<string> dniTygodnia = new List<string>();
dniTygodnia.Add("poniedziałek");
dniTygodnia.Add("wtorek");
dniTygodnia.Add("środa");
dniTygodnia.Add("czwartek");
dniTygodnia.Add("piątek");
dniTygodnia.Add("sobota");
dniTygodnia.Add("niedziela");
dniTygodnia.Add("poniedziałek");

foreach (var dzien in dniTygodnia)
{
    if(dzien == "poniedziałek")
    {
        Console.WriteLine(dzien);
    }
}