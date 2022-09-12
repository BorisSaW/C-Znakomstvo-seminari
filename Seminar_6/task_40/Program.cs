// Задача 40: Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

Console.Write("Введите сторону a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (Triangle(num1, num2, num3)) Console.WriteLine("Может существовать");
else Console.WriteLine("Не может существовать");