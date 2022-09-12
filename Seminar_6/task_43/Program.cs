// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void CrossPoints(double[,] myarray)
{
    double valPoint1 = 0;
    double valPoint2 = 0;
    valPoint1 = (myarray[1, 0] - myarray[0, 0]) / (myarray[0, 1] - myarray[1, 1]);
    valPoint2 = myarray[0, 1] * valPoint1 + myarray[0, 0];
    Console.Write($"Точки пересечения двух прямых: ({valPoint1:f1}; {valPoint2:f1})");
}
double[,] FillArrayMassive(int b1, int k1, int b2, int k2)
{
    double[,] array = new double[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, 0] = b1;
            array[0, 1] = k1;
            array[1, 0] = b2;
            array[1, 1] = k2;
        }
    }
    return array;
}
Console.Write("Введите значение b1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int numk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int numk2 = Convert.ToInt32(Console.ReadLine());
double[,] matrix = FillArrayMassive(numb1, numk1, numb2, numk2);
void FinaleVal(int numb1, int numk1, int numb2, int numk2)
{
    if (numb1 == numb2 && numk1 == numk2) Console.WriteLine("Линии пересекаются");
    else if (numk1 == numk2) Console.WriteLine("Линии параллельны");
    else
    {
        CrossPoints(matrix);
    }
    Console.WriteLine();
}
FinaleVal(numb1, numk1, numb2, numk2);