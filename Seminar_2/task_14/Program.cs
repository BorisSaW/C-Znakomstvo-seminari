﻿//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число ");
int num1 = int.Parse(Console.ReadLine());
int num2 = 7;
int num3 = 23;

if (num1 % num2 == 0 && num1 % num3 == 0) // && - Проверяет условие слева, если не выполняется 
{                                         // выходит из проверки (вторая часть не проверяется)
    Console.WriteLine("Да");              // & Проверяет оба условия
}                                         // || логическое "или"
else
{
    Console.WriteLine("Нет");
}