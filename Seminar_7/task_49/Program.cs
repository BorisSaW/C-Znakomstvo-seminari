// // Задача 49: Задайте двумерный массив. 
// // Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив        Новый массив будет выглядеть вот так:     
//  выглядел вот так:                 
// 1 4 7 2                              1 4 49 2
// 5 9 2 3                              5 81 2 9
// 8 4 2 4                              64 4 4 4
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    int pow = array[i, j];
                    array[i, j] = pow * pow;
                }
            }
        }
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
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns, arrayStart, arrayEnd);
Console.WriteLine("Массив:");
PrintMatrix(newMatrix);
Console.WriteLine("Изменённый массив:");
ChangeMatrix(newMatrix);
PrintMatrix(newMatrix);