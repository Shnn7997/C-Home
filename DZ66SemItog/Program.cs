// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;


WriteLine("Введите число M: ");
int m = Convert.ToInt32(ReadLine());
WriteLine("Введите число N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int Sum(int a, int b)
{
    if (a == b)
        return b;
    return b + Sum(a, b - 1);
}