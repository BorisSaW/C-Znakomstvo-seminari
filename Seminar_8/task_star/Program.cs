// Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, 
// которая принимает на вход целочисленное значение x и возвращает целую часть
// квадратного корня от введенного числа.
// Нельзя использовать встроенные функции библиотеки Math!
int FindSqrt(int num)
{
    int result = 0;
    for (int i = 1; i < num; i++)
    {
        if (i * i <= num) continue;
        else
        {
            result = i - 1;
            break;
        }
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqrtNumber = FindSqrt(number);
Console.WriteLine($"Квадратный корень числа {number} = {sqrtNumber}");