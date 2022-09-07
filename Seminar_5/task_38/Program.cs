// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}
double MinMaxDiff(double[] array)
{
    double MaxNum = array[0];
    double MinNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (MaxNum < array[i])
        {
            MaxNum = array[i];
        }
        if (MinNum > array[i])
        {
            MinNum = array[i];
        }
    }
    return MaxNum - MinNum;
}
double[] myArray = GetArray(5, -10, 10);
double result = MinMaxDiff(myArray);
Console.WriteLine(String.Join(" ", myArray));   
Console.WriteLine(String.Join(" ", result));