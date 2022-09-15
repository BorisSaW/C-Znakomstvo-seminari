// Задача 47. Задайте двумерный массив размером rows×n, заполненный случайными вещественными числами.
// rows = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int l = 0; l < array.GetLength(0); l++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[l, m] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"строк = {rows}, столбцов = {colums}.");
Console.WriteLine();
double[,] array = new double[rows, colums];
CreateArrayDouble(array);
PrintArray(array);