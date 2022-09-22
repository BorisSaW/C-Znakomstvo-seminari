// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NumbersRec(int n, int current = 1)
{
    Console.Write(current);
    if (current < n)
    {
        Console.Write(", ");
        NumbersRec(n, ++current);
    }
}

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersRec(number);