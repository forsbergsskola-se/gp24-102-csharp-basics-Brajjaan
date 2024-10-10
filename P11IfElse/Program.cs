Console.WriteLine("What's your age?");

int age = Int32.Parse(Console.ReadLine()!);

bool isChild = age <=13;
if (isChild) Console.WriteLine("You're a child");

bool isTeenager = age >13 && age <= 18;
if (isTeenager) Console.WriteLine("You're a teenager");

bool isAdult = age > 18;
if (isAdult) Console.WriteLine("You're an adult");

Console.WriteLine("Give me an integer");

int input = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("The maximum is " + age);

int number = input;
if (number % 2 == 0) 
{ 
    Console.WriteLine($"{number} is an even number."); 
} 
else 
{ 
    Console.WriteLine($"{number} is an odd number."); 
} 