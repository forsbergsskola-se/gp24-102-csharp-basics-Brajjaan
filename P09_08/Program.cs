Console.WriteLine("Give me your height");
float height = float.Parse(Console.ReadLine());

Console.WriteLine("Give me your weight");
int weight = int.Parse(Console.ReadLine());

float bmi = weight / (height*height);

Console.WriteLine("BMI is {0}", bmi);