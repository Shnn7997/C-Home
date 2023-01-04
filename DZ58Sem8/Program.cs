// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
using static System.Console;



Write("Введите размер матрицы через пробел ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);

Write("Введите размер матрицы 2 через пробел ");
string[] sizeS2 = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows2 = int.Parse(sizeS2[0]);
int columns2 = int.Parse(sizeS2[1]);
int[,] ar2 = GetRandomArray(rows2, columns2);
PrintArray(ar2);

int[,] resultAr = new int[rows, columns2];

MultiplyMatrix(ar, ar2, resultAr);
WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultAr);

void MultiplyMatrix(int[,] ar, int[,] ar2, int[,] resultAr)
{
    for (int i = 0; i < resultAr.GetLength(0); i++)
    {
        for (int j = 0; j < resultAr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ar.GetLength(1); k++)
            {
                sum += ar[i, k] * ar2[k, j];
            }
            resultAr[i, j] = sum;
        }
    }
}




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