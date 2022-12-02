using System;
using static System.Console;
//using System.Collections.Generic;
//using System.Text;

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

namespace ConsoleApplicationMax
{
    class Program
    {
        static void Main(string[] args)

        {
            WriteLine("Введите число а");
            double a = Convert.ToDouble(ReadLine());
            WriteLine("Введите число b");
            double b = Convert.ToDouble(ReadLine());
            WriteLine("Введите число c");
            double c = Convert.ToDouble(ReadLine());
            double max;

            max = Math.Max(a, Math.Max(b, c));

            WriteLine($"Число {max} - максимальное из 3х введенных чисел");

            ReadLine();
        }
    }
}