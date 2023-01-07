using System;
using static System.Console;


WriteLine("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());
WriteLine($"Сумма элементов от {a} до {b} = {Sum(a, b)}");

int Sum(int a, int b)
{
    if (a == b)
        return b;
    return b + Sum(a, b - 1);
}