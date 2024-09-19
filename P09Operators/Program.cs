
#region
/* OLD CODE - MAYBE NOT ALLOWED MAYBE ALLOWED, WHO KNOWS?
Console.WriteLine("Give me a number of seconds");
int input = int.Parse(Console.ReadLine());

int totalSeconds = input;
TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);

int days = timeSpan.Days;
int hours = timeSpan.Hours;
int minutes = timeSpan.Minutes;
int seconds = timeSpan.Seconds;

double totalDays = totalSeconds / 86400.0;

string format = $"{timeSpan.Days:D1}.{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";

Console.WriteLine(seconds);
Console.WriteLine(minutes);
Console.WriteLine(hours);
Console.WriteLine(days);

Console.WriteLine(format);

Console.WriteLine($"total days: {totalDays}");*/
#endregion

Console.WriteLine("Give me a number of seconds");
int inputSeconds = int.Parse(Console.ReadLine());

int remainingSeconds = inputSeconds % (24 * 3600);
int days = inputSeconds / (24 * 3600);
int hours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int minutes = remainingSeconds / 60;
int seconds = remainingSeconds % 60;

Console.WriteLine("number of days "+days);
Console.WriteLine("number of hours "+hours);
Console.WriteLine("number of minutes "+minutes);
Console.WriteLine("number of seconds "+seconds);
