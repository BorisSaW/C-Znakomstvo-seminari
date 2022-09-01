// Задача 22: Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.Write($"{Math.Pow(count,2)} ");
    count++;
}
Console.WriteLine();

for (int i = 1; i <= number; i++)   // Цикл for :начала тип данных (переменную цикла) ; условие когда цикл существует;
{                                   // как и с каким шагом (i++)            
    Console.Write($"{i*i} ");
}
