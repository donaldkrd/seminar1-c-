Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number % 2 == 0)
{
    Console.WriteLine ($"{number} Четное число");
}
else
{
    Console.WriteLine ($"{number} не четное число");
}