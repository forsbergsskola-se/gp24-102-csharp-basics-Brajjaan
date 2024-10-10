string chars = "!#¤%&/()=?abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

Random random = new Random();
string password = String.Empty;

for (int i = 0; i < 10; i++)
{
    password += chars[random.Next(chars.Length)];
}

Console.WriteLine($"new password is: {password}");

string gotoPassword = String.Empty;

backtrack:

gotoPassword += chars[random.Next(chars.Length)];

if (gotoPassword.Length < 6);

