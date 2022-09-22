// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int Ackermann(int m, int n)
{
    if (m > 0 & n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    else if (m > 0 & n == 0) return Ackermann(m - 1, 1);
    else return n + 1;
}
System.Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberAckermann = Ackermann(numberM, numberN);
Console.WriteLine($"Ackermann(m,n) =  {numberAckermann}");