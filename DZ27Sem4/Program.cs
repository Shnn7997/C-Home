// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
using System;
using static System.Console;

WriteLine("Введите число");
WriteLine($"Сумма цифр  в числе = {DigitSum(Convert.ToInt32(ReadLine()))}");





int DigitSum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}