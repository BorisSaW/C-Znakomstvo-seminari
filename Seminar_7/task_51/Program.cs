// // Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:             //Сумма элементов главной диагонали: 1+9+2 = 12
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int[,] GetMatrix(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}
void PrintMatrix(int[,] array)
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
int FindElemets(int[,] array)
{
    int result = 0;
    int minElement = 0;
    if (array.GetLength(0) <= array.GetLength(1)) minElement = array.GetLength(0) - 1;
    else minElement = array.GetLength(1) - 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i <= minElement) result += array[i, i];
    }
    return result;
}
Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns, arrayStart, arrayEnd);
Console.WriteLine("Массив:");
PrintMatrix(newMatrix);
Console.WriteLine($"Сумма эдементов по диагонали: {FindElemets(newMatrix)}");