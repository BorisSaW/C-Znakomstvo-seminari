// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] PositiveAndNegativeSum(int[] array)
{
    int[] res = new int[2];              //Передаем массив из двух элементов

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            res[0] += array[i]; //Если условие выполняется, первый элемент массива res в значение на элемент array[i] больше
        }
        else
        {
            res[1] += array[i];
        }
    }
    
    return res;
}
//                     size min max

void PositiveSum(int[] array)
{
    int PositiveSum = 0;
    foreach(int el in array )  //не по индексам а по элементам
    {
        PositiveSum += el > 0 ? el : 0;  //Тернарный (Условный) оператор. Если условие слева от ? выполняется
        // if(el > 0)                       // подставляется значение el после =+, а если нет, то приравнивает к 0
        // {
        //     PositiveSum += el;
        // }
        // else
        // {
        //     PositiveSum += 0;
        // }
    } 
    Console.WriteLine($"{PositiveSum}");
}
void NegativeSum(int[] array)
{
    int NegativeSum = 0;
    foreach(int el in array )  //не по индексам а по элементам
    {
        NegativeSum += el < 0 ? el : 0;  //Тернарный (Условный) оператор. Если условие слева от ? выполняется
        // if(el > 0)                       // подставляется значение el после =+, а если нет, то приравнивает к 0
        // {
        //     PositiveSum += el;
        // }
        // else
        // {
        //     PositiveSum += 0;
        // }
    } 
    Console.WriteLine($"{NegativeSum}");
}

int[] myArray = GetArray(10, -100, 100); //Создаем свой массив от 0 до 10
int[] result = PositiveAndNegativeSum(myArray);  //Создаем массив результатов вызвав функцию PositiveAndNegativeSum 
                                        // и передаем в качестве параметра myArray
Console.WriteLine(String.Join(" ", myArray));   //Выводим изначальный массив
Console.WriteLine(String.Join(" ", result));
PositiveSum(myArray);
NegativeSum(myArray);