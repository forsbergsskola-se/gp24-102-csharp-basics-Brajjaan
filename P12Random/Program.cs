Console.WriteLine("Pass me a seed");

int seed = Int32.Parse(Console.ReadLine());

Random random = new Random(seed);

int num1 = random.Next(0, 5);
int num2 = random.Next(0, 5);
int num3 = random.Next(0, 5);

Console.WriteLine("Three integers between 0-5");
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num3);

Console.WriteLine("Three numbers between 0 - 0.5");

double num4 = random.NextDouble()*0.5;
double num5 = random.NextDouble()*0.5;
double num6 = random.NextDouble()*0.5;

Console.WriteLine(num4);
Console.WriteLine(num5);
Console.WriteLine(num6);

Console.WriteLine("three numbers between 0.2 -0.7");

double num7 = random.NextDouble()*(0.7 - 0.2) + 0.2;
double num8 = random.NextDouble()*(0.7 - 0.2) + 0.2;
double num9 = random.NextDouble()*(0.7 - 0.2) + 0.2;

Console.WriteLine(num7);
Console.WriteLine(num8);
Console.WriteLine(num9);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");

Double chance = Double.Parse(Console.ReadLine());


for (int i = 0; i < 5; i++)
{
   

    if (random.NextDouble() < chance)
    {
        Console.WriteLine("crit");
    }
    else Console.WriteLine("no crit");

}






