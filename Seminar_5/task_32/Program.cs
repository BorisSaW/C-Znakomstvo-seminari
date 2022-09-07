// Задача 32: Напишите программу замена элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ChangeArray(int[] array)
{
    for(int i = 0; i <array.Length; i++)
    {
        array[i] = -array[i];
    }   
}


int[] myArray = GetArray(4, 0, 10);
Console.WriteLine(String.Join(" ", myArray));
ChangeArray(myArray);
Console.WriteLine(String.Join(" ", myArray));