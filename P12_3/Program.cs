Console.WriteLine("A magical chest randomly spawns!");
Thread.Sleep(2000);

string[] items = { "Gold Coin", "Bronze Coin", "Silver Coin", "Platinum Coin", "Wrapping paper" };

Random random = new Random();
string chestOpen = items [random.Next(items.Length)];


Console.WriteLine("You slowly open the chest");
Thread.Sleep(2000);
Console.WriteLine($"You found a {chestOpen}");