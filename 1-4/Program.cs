Console.WriteLine("Введите число1: ");
string input1 = Console.ReadLine();
int a = int.Parse(input1);
int count = 2;
while (count <= a)
{
    Console.WriteLine(count);
    count += 2;
}
