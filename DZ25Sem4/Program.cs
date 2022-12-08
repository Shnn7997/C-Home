// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

using System;
using static System.Console;


//WriteLine("Введите число:");
//int number = Convert.ToInt32(ReadLine());
//WriteLine("Введите второе число:");
//int number2 = Convert.ToInt32(ReadLine());
//int PowNumber=Convert.ToInt32(Math.Pow(number,number2));
//WriteLine($"Число {number} в степени {number2} равно {PowNumber}");


Write("Введите первое число: ");
int number = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

int exp = PowN(number, number2);
WriteLine($"Число {number} в степени {number2} равно {exp}");


int PowN (int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}