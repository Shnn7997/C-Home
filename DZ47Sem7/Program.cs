//47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.






using System;
using static System.Console;

Clear();

Write("Введите размер матрицы через пробел ");
string[] sizeS=ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double rows=double.Parse(sizeS[0]);
double columns = double.Parse(sizeS[1]);
double[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);



double[,] GetRandomArray(double row, double column)
{
   double[,] result=new double[(int)row, (int)column]; 
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
    return result;
}



void PrintArray(double[,] array)
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