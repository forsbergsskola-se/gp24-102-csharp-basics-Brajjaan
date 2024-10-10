Console.WriteLine("Convert Km/h to M/s");

double kmph = Convert.ToDouble(Console.ReadLine());

double mps = kmph * 1000 / 3600;

Console.WriteLine($"{mps} m/s");