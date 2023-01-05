// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

using System;
using static System.Console;



Write("Введите размер матрицы через пробел ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int x = int.Parse(sizeS[0]);
int y = int.Parse(sizeS[1]);
int z = int.Parse(sizeS[2]);
int[,,] ar = GetRandomArray(x, y, z);
PrintArray(ar);



int[,,] GetRandomArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(-10, 100);
            }
            
        }
    }
    return result;
}



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Write($"Z({k}) X({i}) Y({j})={array[i, j, k]}; ");
            }
            WriteLine();
        }
        WriteLine();
    }
}