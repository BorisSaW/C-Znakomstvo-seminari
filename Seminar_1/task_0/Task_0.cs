Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
// Console.WriteLine("Результат = {0}", sqr); Один из вариантов
//Console.WriteLine($"Результат = {sqr}");
int result = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Результат = {result}");

