// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ElementCount(int[] arr)
{
    int count = 0;
    foreach(var item in arr)
    {
        if (item >= 10 && item <= 99)
        count++;
    }
    return count;
}

int[] myArray = GetArray(123, 10, 99);
Console.WriteLine(String.Join(" ", myArray));
int result = ElementCount(myArray);

Console.WriteLine($"Колличество элементов {result}");