Console.WriteLine("Введите число1: ");
string input1 = Console.ReadLine();
int a = int.Parse(input1);

Console.WriteLine("Введите число2: ");
string input2 = Console.ReadLine();
int b = int.Parse(input2);

if (a > b)
{
    Console.WriteLine("max " + a);
    Console.WriteLine("min " + b);
}
else
{
    Console.WriteLine("max " + b);
    Console.WriteLine("min " + a);
}
