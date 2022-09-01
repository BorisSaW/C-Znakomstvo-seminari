// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
int z2 = int.Parse(Console.ReadLine());

int sqr1 = (x1 - x2) * (x1 - x2);
int sqr2 = (y1 - y2) * (y1 - y2);
int sqr3 = (z1 - z2) * (z1 - z2);
int sum = (sqr1 + sqr2 +sqr3);

double result = Math.Sqrt(sum);
Console.WriteLine($"Результат {result:f2}");    // f - Говорит что дробное число и сколько знаков(в данном случае 2)

