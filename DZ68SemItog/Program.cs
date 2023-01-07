// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;
using static System.Console;


WriteLine("Введите число m: ");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число n: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int i, int j)
{
    if (i == 0)
        return j + 1;
    if (i > 0 && j == 0)
        return Akkerman(i - 1, 1);
    else
        return Akkerman(i - 1, Akkerman(i, j - 1));
}