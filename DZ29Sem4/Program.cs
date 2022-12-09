// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
using static System.Console;
using getranarray;

int[] array = Gra.GetRandomArray(8);
WriteLine(String.Join(",", array));

namespace getranarray
{
    public class Gra
    {
        public static int[] GetRandomArray(int size)
        {
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i]=new Random().Next(8);
            }
            return result;
        }
    }
}