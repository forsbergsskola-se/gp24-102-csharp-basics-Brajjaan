Random random = new Random();
int randomNumber = random.Next(1, 100);
Console.WriteLine("I have picked a number between (1-100) it's your turn to guess it!");

bool gameEnd = false;
int wrongGuess = 0;

while (!gameEnd)
{
    Console.WriteLine("Have a guess");
    int playerGuess = int.Parse(Console.ReadLine()!);
    
    if (playerGuess == randomNumber)
    {
        Console.WriteLine("You guessed it!");
        gameEnd = true;
    }
    else if (playerGuess > randomNumber)
    {
        Console.WriteLine("too high, try again!");
        wrongGuess++;
    }
    else
    {
        Console.WriteLine("too low, try again");
        wrongGuess++;
    }

    if (wrongGuess >= 10)
    {
        Console.WriteLine("Out of attempts! Game over!");
        gameEnd = true;
    }
}

Console.WriteLine("Wrong guesses: "+ wrongGuess);

