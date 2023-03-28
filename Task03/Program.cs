/* Задача 15: Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет  */

Console.Clear();

Console.WriteLine("Введите цифру дня недели:  ");

string day = Console.ReadLine();

int d = int.Parse(day);

/*if (d == 1)
{
  Console.WriteLine("НЕТ");
}

if (d == 2)
{
  Console.WriteLine("НЕТ");
}

if (d == 3)
{
  Console.WriteLine("НЕТ");
}

if (d == 4)
{
  Console.WriteLine("НЕТ");
}

if (d == 5)
{
  Console.WriteLine("НЕТ");
}

if (d == 6)
{
  Console.WriteLine("ДА");
}

if (d == 7)
{
  Console.WriteLine("ДА");
}

else
{
  if(d > 7)
  Console.WriteLine("Нет такого дня недели");
}*/

if (d > 0 && d < 6)
{
  Console.WriteLine($"{d} -> Нет");
}
if (d > 5 && d < 8)
{
  Console.WriteLine($"{d} -> Да");
}

