Console.WriteLine("Give me the lenght of the first side");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Give me the lenght of the second side");
double b = double.Parse(Console.ReadLine());

double hypotenuse = Math.Sqrt(a * a + b * b); // or Math.Sqrt(Math.pow(a,2)+Math.pow(a,2)

Console.WriteLine(hypotenuse);