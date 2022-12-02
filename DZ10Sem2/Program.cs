//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;
using static System.Console;

int number = new Random().Next(100, 1000);
WriteLine(number);
while (number >= 100) number /= 10;
int SecondDigit = number % 10;
WriteLine(SecondDigit);
ReadKey();

