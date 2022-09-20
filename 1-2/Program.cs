Console.WriteLine("Введите число1: ");
string input1 = Console.ReadLine();
int a = int.Parse(input1);

Console.WriteLine("Введите число2: ");
string input2 = Console.ReadLine();
int b = int.Parse(input2);

Console.WriteLine("Введите число3: ");
string input3 = Console.ReadLine();
int c = int.Parse(input3);

if (a > b && b > c)
{
    Console.WriteLine("max " + a);
}
else if (b > a && b > c)
{
    Console.WriteLine("max " + b);
}
else if (c > b && b > a)
{
    Console.WriteLine("max " + c);
}
