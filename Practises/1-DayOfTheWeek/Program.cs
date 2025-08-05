Console.WriteLine("Please enter your number for show weekday:");
string inputNumber = Console.ReadLine();
int num = int.Parse(inputNumber);

if (num > 7 || num < 1)
{
    Console.WriteLine("Wrgon number");
}
else
{
    if (inputNumber == "1")
    {
        Console.WriteLine("Saturday");
    }
    else if (inputNumber == "2")
    {
        Console.WriteLine("Sunday");
    }
    else if (inputNumber == "3")
    {
        Console.WriteLine("Monday");
    }
    else if (inputNumber == "4")
    {
        Console.WriteLine("Tuesday");
    }
    else if (inputNumber == "5")
    {
        Console.WriteLine("Wednesday");
    }
    else if (inputNumber == "6")
    {
        Console.WriteLine("Thursday");
    }
    else if (inputNumber == "7")
    {
        Console.WriteLine("Friday");
    }
    else
    {
        Console.WriteLine("wrong input number");
    }
}

Console.WriteLine("End Program");

Console.ReadKey();
