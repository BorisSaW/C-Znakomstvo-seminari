// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int SearchPositiveNums(int numbers)
{
    int result = 0;
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int nums = Convert.ToInt32(Console.ReadLine());
        if (nums > 0) result++;
    }
    return result;
}
Console.Write("Введите колличество чисел: ");
int countNumbers = int.Parse(Console.ReadLine());
int newNums = SearchPositiveNums(countNumbers);
Console.WriteLine();
Console.WriteLine($"Положительных чисел: {newNums}");