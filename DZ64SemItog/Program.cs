// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

WriteLine("Введите положительное число: ");
int n = Convert.ToInt32(ReadLine());
int m = 1;
if (n < 1)
{
    WriteLine("Нужно положительное, поправим!");
    n = n * -1;
}
WriteLine(NumberN(n, m));

int NumberN(int n, int m)
{
    if (n == m)
        return n;
    else
        Write($"{NumberN(n, m + 1)}, ");
    return m;
}