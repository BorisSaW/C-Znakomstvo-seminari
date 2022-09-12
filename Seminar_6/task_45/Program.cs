// Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}
int[] myArray = GetArray(10, 0, 10);
Console.Write($"Массив: [{String.Join(", ", myArray)}]");
Console.WriteLine();
Console.Write($"Копия массива: [{String.Join(", ", CopyArray(myArray))}]");
Console.WriteLine();