// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
void multiplicationMatrix(int[,] prodMatrix, int[,] firstMatrix, int[,] secondMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(1); k++)
            {
                prodMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
}
Console.Write("Введите количество строк первой матрицы: ");
int arrayRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int arrayColumns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int arrayRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int arrayColumns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = GetMatrix(arrayRows1, arrayColumns1, arrayStart, arrayEnd);
int[,] matrix2 = GetMatrix(arrayRows2, arrayColumns2, arrayStart, arrayEnd);
int[,] multiplicationArrayMatrix = new int[arrayRows1, arrayColumns2];
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);
if (arrayColumns1 == arrayRows2)
{
    multiplicationMatrix(multiplicationArrayMatrix, matrix1, matrix2);
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(multiplicationArrayMatrix);
}
else Console.WriteLine("Нельзя найти произведение матриц.");