using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Give me a number");



string number = Console.ReadLine();

float numberAsFloat = float.Parse(number);

Console.WriteLine(numberAsFloat);

int numberAsInt = Convert.ToInt32(numberAsFloat);


numberAsInt = (int)numberAsFloat;

Console.WriteLine(numberAsInt);


