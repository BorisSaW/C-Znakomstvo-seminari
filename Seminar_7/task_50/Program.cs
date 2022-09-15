// Задача 50. Напишите программу, которая на вход принимает число
// и генерирует случайный двумерный массив,
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] CreateArrayDouble(int row, int column, int beginArray, int endArray)
{
    int[,] newArrayDouble = new int[row, column];
    for (int i = 0; i < newArrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < newArrayDouble.GetLength(1); j++)
        {
            newArrayDouble[i, j] = new Random().Next(beginArray, endArray);
        }
    }
    return newArrayDouble;
}
void SearchPosition(int[,] array, int numbers)
{
    int count = 0;
    int countPosition = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numbers)
            {

                Console.WriteLine($"Позиция числа {countPosition}: Строка {i}, Столбец {j});");
                countPosition++;
                count++;
            }
        }

    }
    if (count > 0) return;
    else Console.WriteLine("Элемент не в массиве");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateArrayDouble(arrayRows, arrayColumns, arrayStart, arrayEnd);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
Console.Write("Введите число для поиска: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
SearchPosition(newArray, searchNumber);