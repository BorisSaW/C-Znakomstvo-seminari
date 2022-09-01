// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.Write($"{Math.Pow(count,3)} ");  // Попробовал так, но можно было как на семинаре {count*count*count}
    count++;
}
Console.WriteLine();

//Либо так
// for (int i = 1; i <= num; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }
// Console.WriteLine();