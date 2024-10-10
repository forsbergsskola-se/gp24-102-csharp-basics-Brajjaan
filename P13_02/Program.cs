Console.WriteLine("type in your value");

retry:
bool success = int.TryParse(Console.ReadLine(), out int value);

if (!success)
{
    goto retry;
}

Continue :

Console.WriteLine(new string ('#', value --));

if (value > 0)
{
    goto Continue;
}