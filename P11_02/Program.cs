Console.WriteLine("Give me first number");
int num1= int.Parse(Console.ReadLine());

Console.WriteLine("Give me second number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Give me third number");
int num3 = int.Parse(Console.ReadLine());

int minNum = 0;
int maxNum = 0;
//Max number condition
    if (num1 > num2 && num1 > num3)
    {
        maxNum = num1;
    }
    
    else if (num2 > num1 && num2 > num3)
    {
        maxNum = num2;
    }
    
    else if (num3 > num2 && num3 > num1)
    {
        maxNum = num3;
    }

// min number condition
    if (num1 < num2 && num1 < num3)
    {
        minNum = num1;
    }
    
    else if (num2 < num1 && num2 < num3)
    {
        minNum = num2;
    }
    
    else if (num3 < num2 && num3 < num1)
    {
        minNum = num3;
    }
    
    Console.WriteLine($"Min = {minNum}");
    Console.WriteLine($"Max = {maxNum}");