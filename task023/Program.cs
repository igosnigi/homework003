Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = 1;

while (i<=number)
{
    Console.Write(Math.Pow(i, 3));
    if (i !=number)
        Console.Write(", ");
    i++;
}
