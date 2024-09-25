Console.WriteLine("Give me a number");
int number = int.Parse(Console.ReadLine());

    if (number >= 90 && number <= 100)
    {
        Console.WriteLine("Letter grade is A");
    }
    else if (number >= 80 && number <= 89)
    {
        Console.WriteLine("Letter grade is B");
    }
    else if (number >= 70 && number <= 79)
    {
        Console.WriteLine("Letter grade is C");
    }
    else if (number >= 60 && number <= 59)
    {
        Console.WriteLine("Letter grade is D");
    }
    else if (number < 60)
    {
        Console.WriteLine("Letter grade is F");
    }