// Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа 
//или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

int a1 = number / 100;
int a2 = a1 % 10;

int result = a2;

if(number >= 100)
{
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
