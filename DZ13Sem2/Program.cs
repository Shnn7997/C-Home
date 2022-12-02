// Задача 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;
using static System.Console;

Write("Введи число: ");
int Number = Convert.ToInt32(ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
    WriteLine("третья цифра:" + NumberText[2]);
}
else
{
    WriteLine("третьей цифры нет");
}
