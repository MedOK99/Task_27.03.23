﻿/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();

Console.WriteLine("Введите трёхзначное число ");

int num = int.Parse(Console.ReadLine()!);

int num2 = num % 10;
int num3 = ((num - num2) / 10) %10;

if(num > 99 && num < 1000)
{
Console.WriteLine(num3);
}

else
{
  Console.WriteLine("Вы ввели НЕ трёхзначное число!");
}
