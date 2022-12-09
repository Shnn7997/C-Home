// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
using static System.Console;
using getranarray;

int[] array = Gra.GetRandomArray(8);
WriteLine(String.Join(",", array));