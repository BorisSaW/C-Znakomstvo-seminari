// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
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

int[] FindMinimum(int[,] array, int[] minArray)
{
    int minimunNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minimunNumber > array[i, j])
            {
                minimunNumber = array[i, j];
                minArray[0] = i;
                minArray[1] = j;
            }
        }
    }
    return minArray;
}

int[,] ChangeArray(int[,] array, int[] deleteArray)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0, l = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != deleteArray[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != deleteArray[1])
                {
                    result[l, k] = array[i, j];
                    k++;
                }
            }
            k = 0;
            l++;
        }
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
PrintMatrix(newMatrix);
int[] minimunPositions = new int[2];
minimunPositions = FindMinimum(newMatrix, minimunPositions);
int[,] resultArray = ChangeArray(newMatrix, minimunPositions);
Console.WriteLine();
PrintMatrix(resultArray);