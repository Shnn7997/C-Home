//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;
using static System.Console;


Write("Введите номер дня недели: ");
int dayN = Convert.ToInt32(ReadLine());

{
    if (dayN == 6 || dayN == 7)
    {
        WriteLine($"{dayN}: этот день выходной");
    }
    else if (dayN < 1 || dayN > 7)
    {
        WriteLine($"{dayN}: нет такого дня недели");
    }
    else WriteLine($"{dayN} день не выходной");
}

