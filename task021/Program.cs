Console.Clear();

Console.WriteLine("Введите координату х первой точки: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y первой точки: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z первой точки: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату х второй точки: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y второй точки: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z второй точки: ");
double z2 = double.Parse(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine ("{0:0.00}", s);