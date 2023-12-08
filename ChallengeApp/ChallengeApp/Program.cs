int number = 497248;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int number0 = 0;
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        number0 = number0 + 1;
    }
    else if (letter == '1')
    {
        number1 = number1 + 1;
    }
    else if (letter == '2')
    {
        number2 = number2 + 1;
    }
    else if (letter == '3')
    {
        number3 = number3 + 1;
    }
    else if (letter == '4')
    {
        number4 = number4 + 1;
    }
    else if (letter == '5')
    {
        number5 = number5 + 1;
    }
    else if (letter == '6')
    {
        number6 = number6 + 1;
    }
    else if (letter == '7')
    {
        number7 = number7 + 1;
    }
    else if (letter == '8')
    {
        number8 = number8 + 1;
    }
    else if (letter == '9')
    {
        number9 = number9 + 1;
    }
}

Console.WriteLine("Ilość wystąpień cyfry 0 we wskazanej liczbie: " + number0);
Console.WriteLine("Ilość wystąpień cyfry 1 we wskazanej liczbie: " + number1);
Console.WriteLine("Ilość wystąpień cyfry 2 we wskazanej liczbie: " + number2);
Console.WriteLine("Ilość wystąpień cyfry 3 we wskazanej liczbie: " + number3);
Console.WriteLine("Ilość wystąpień cyfry 4 we wskazanej liczbie: " + number4);
Console.WriteLine("Ilość wystąpień cyfry 5 we wskazanej liczbie: " + number5);
Console.WriteLine("Ilość wystąpień cyfry 6 we wskazanej liczbie: " + number6);
Console.WriteLine("Ilość wystąpień cyfry 7 we wskazanej liczbie: " + number7);
Console.WriteLine("Ilość wystąpień cyfry 8 we wskazanej liczbie: " + number8);
Console.WriteLine("Ilość wystąpień cyfry 9 we wskazanej liczbie: " + number9);