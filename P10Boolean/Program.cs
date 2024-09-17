Console.WriteLine("What's your age?");


int age = Convert.ToInt32(Console.ReadLine());

bool isChild = age <= 12;
bool isTeenager = age >= 13 && age <= 18;
bool isAdult = age >= 19;

Console.WriteLine("You're a child "+isChild);
Console.WriteLine("You're a teenager "+isTeenager);
Console.WriteLine("You're an adult "+isAdult);

