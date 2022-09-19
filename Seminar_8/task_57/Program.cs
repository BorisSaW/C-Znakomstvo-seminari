// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
int[,] GetMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
int[] TwoDimensiostoOne(int[,] res)  // Выпрямление метода
{
    int[] temp = new int[res.GetLength(0) * res.GetLength(1)];
    int k = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            temp[k] = res[i, j];
            k++;
        }
    }
    return temp;
}
int[] SortUp(int[] myArray)
{
    for (int i = 0; i < myArray.Length - 1; i++)
    {
        for (int j = i + 1; j < myArray.Length; j++)
        {
            if (myArray[i] > myArray[j])
            {
                int temp = myArray[j];
                myArray[j] = myArray[i];
                myArray[i] = temp;
            }
        }
    }
    return myArray;
}
void CountValues(int[] inputArray)
{
    int counter = 1;
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        if (inputArray[i] == inputArray[i + 1])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"Value {inputArray[i]} {counter} times in array");
            counter = 1;
        }
    }
    Console.WriteLine($"Value {inputArray[inputArray.Length - 1]} {counter} times in array");
}
Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Исходный массив: ");
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns);
PrintMatrix(newMatrix);
Console.WriteLine("Частотный словарь: ");
int[] newArray = TwoDimensiostoOne(newMatrix);
SortUp(newArray);
CountValues(newArray);