int height = 100;
int width = 100;

Random random = new Random();

int enemyX = random.Next(0, height);
int enemyY = random.Next(0, width);

Console.WriteLine($"Enemy at X:{enemyX}, Y:{enemyY}");