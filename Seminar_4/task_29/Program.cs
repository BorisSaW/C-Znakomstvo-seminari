// Задача 29: Напишите программу, которая задаёт массив из N элементов, 
// заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int Arraylen = ReadInt("Введите длинну массива: ");
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
int[] randomArray = new int[Arraylen];


for (int i = 0; i < randomArray.Length && i != randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(numberA, numberB);
    Console.Write(randomArray[i] + " ");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

