string chars = "!#¤%&/()=?abcdefghijklmnopqrstuvwxyz0123456789";

Random random = new Random();
string password = String.Empty;

for (int i = 0; i < 10; i++)
{
    password += chars[random.Next(chars.Length)];
}

Console.WriteLine($"type your new password: {password}");

string gotoPassword = String.Empty;

backtrack:

gotoPassword += chars[random.Next(chars.Length)];

if (gotoPassword.Length < 6);

