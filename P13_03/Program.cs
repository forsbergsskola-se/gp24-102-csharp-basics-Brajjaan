string pattern1 = "#-#-#-#-#-";
string pattern2 = "-#-#-#-#-#-";

Console.WriteLine("Enter size");
string input = Console.ReadLine();
int size = int.Parse(input);

Backtrack:

Console.WriteLine(size % 2 == 0 ? pattern1 : pattern2);

size--;
if (size > 0)
    goto Backtrack;
