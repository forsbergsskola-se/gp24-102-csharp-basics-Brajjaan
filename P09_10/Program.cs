Console.WriteLine("Give me a value in seconds");

int seconds = int.Parse(Console.ReadLine());
int minutes = seconds / 60;
int remainingSeconds = seconds % 60;

Console.WriteLine($"{minutes} minute(s) and {remainingSeconds} second(s)");