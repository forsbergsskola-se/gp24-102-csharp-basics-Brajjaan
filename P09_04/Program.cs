Console.WriteLine("Give me the first integer");

int int1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give me the second integer");

int int2 = Convert.ToInt32(Console.ReadLine());

int result= int1 % int2;

Console.WriteLine($"The remainder of {int1} % {int2} is {result}");