#region old code
/*
MISSUNDERSTOOD THE ASSIGNMENT
int balance =  50;
bool transactionComplete = false;


while (!transactionComplete)
{
    Console.WriteLine($"How much would you like to withdraw? Current balance is {balance} dollars");
    int withdraw = int.Parse(Console.ReadLine());
    if (withdraw > balance)

    {
        Console.WriteLine("Insufficient balance");
    }
    else if (withdraw <= balance)
    {
        balance = balance - withdraw;
        Console.WriteLine($"You have withdrawn {withdraw} dollars. Current bank balance {balance} dollars");
        transactionComplete = true;
    }
}
*/
#endregion


Console.WriteLine("How much would you like to withdraw?");

int withdrawAmount;

while (!int.TryParse(Console.ReadLine(), out withdrawAmount))
{
    Console.WriteLine("Please enter a valid number");
}

Console.WriteLine($"{new string('$', withdrawAmount)}");


