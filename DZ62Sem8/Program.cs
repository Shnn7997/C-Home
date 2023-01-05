// Задача 62: Заполните спирально массив 4 на 4.

using System;
using static System.Console;


int n = 4;
int[,] sqArr = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqArr.GetLength(0) * sqArr.GetLength(1))
{
    sqArr[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqArr.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqArr.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqArr.GetLength(1) - 1)
        j--;
    else
        i--;
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

PrintArray(sqArr);