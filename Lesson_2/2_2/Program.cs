
Console.WriteLine("Enter three-digit number:");
//int a = int.Parse(Console.ReadLine()!);

int a = int.Parse(Console.ReadLine()!);

int firstDigit = a / 10 % 10;
int thirdDigit = a % 10;

Console.WriteLine(Math.Pow(firstDigit,thirdDigit));
