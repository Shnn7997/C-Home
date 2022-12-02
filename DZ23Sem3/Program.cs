//Написать программу, которая на вход принимает число N и выдает таблицу кубов чисел от 1 до N

using System;
using static System.Console;

WriteLine("Введите число");
int N = Convert.ToInt32(ReadLine());

int count = 1;
while(count < N)
{
    Write($"{Math.Pow(count, 3)}, ");
    count++;
}
Write($"{Math.Pow(count, 3)}");