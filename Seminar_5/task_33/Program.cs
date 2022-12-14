// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool IsExist(int number, int[] arr)
{
    foreach (var item in arr)
    {
    if(item == number)
    return true;
    }
    return false;
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());


int[] myArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", myArray));

if (IsExist(number, myArray))
Console.WriteLine("Число найдено");      // Если из ветки bool вернется true то пишет найдено и наоборот
else 
Console.WriteLine("Число не найдено");