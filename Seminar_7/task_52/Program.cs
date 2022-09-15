// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] GetArray(int rows, int columns, int startArray, int endArray)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(startArray, endArray + 1);
        }
    }
    return result;
}
void FindAverage(int[,] biArray)
{
    int count = 0;
    for (int l = 0; l < biArray.GetLength(1); l++)
    {
        double TempAverage = 0;
        double sumRows = 0;
        for (int m = 0; m < biArray.GetLength(0); m++)
        {
            sumRows += biArray[m, l];
        }
        TempAverage = sumRows / biArray.GetLength(0);
        count++;
        Console.WriteLine($"Среднее арифметическое {count} столбца = {TempAverage:f};");
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
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
int[,] newArray = GetArray(arrayRows, arrayColumns, arrayStart, arrayEnd);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine();
FindAverage(newArray);