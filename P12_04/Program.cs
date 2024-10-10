Random random = new Random();
bool gameEnd = false;


while (!gameEnd)
{
    double messageChance = random.NextDouble();    
    
    if (messageChance <= 0.1)
    {
        Console.WriteLine("This is a secret message");
        gameEnd = true;
    }

    else
    {
        Console.WriteLine("Try Again");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}