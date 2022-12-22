// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
using static System.Console;


Clear();

Write("Введите размер матрицы через пробел ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);
WriteLine("Среднее арефметическое каждого столбца:");
SA(ar);





int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-100, 100);
        }
    }
    return result;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}




void SA(int[,] csum)
{
    for(int j = 0; j < csum.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < csum.GetLength(0); i++)
        {
            sum = sum + csum[i, j];
        }
            WriteLine($"{(sum / csum.GetLength(0)):f1}");
    }
}