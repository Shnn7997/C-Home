using System;
using static System.Console;


Clear();

Write("Введите размер матрицы через пробел ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);
int[,] ar = GetRandomArray(rows, columns);
//Write("Введите индекс строки ");
//int rowInd = Convert.ToInt32(ReadLine());
//Write("Введите индекс столбца ");
//int colInd = Convert.ToInt32(ReadLine());
PrintArray(ar);
FiltEl(ar);





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

//if (rowInd > rows && colInd > columns)
//    WriteLine($"Элемента с индексом {rowInd},{colInd} нет в массиве");
//else
//{
//    object elVol = ar.GetValue(rowInd, colInd);
//    WriteLine($"{elVol} - элемент с индексом {rowInd},{colInd}");
//}


void FiltEl(int[,] element)
{
    WriteLine("Введите индекс строки ");
    var rowInd = Convert.ToInt32(ReadLine());
    WriteLine("Введите индекс столбца ");
    var colInd = Convert.ToInt32(ReadLine());
    for(int i = 0; i < element.GetLength(0); i++)
    {
        if (rowInd < 0 | rowInd >= element.GetLength(0) | colInd < 0 | colInd >= element.GetLength(1))
        {
            WriteLine($"Элемента с индексом {rowInd},{colInd} в массиве нет");
            break;
        }
        for(int j = 0; j < element.GetLength(1); j++)
        {
            if(i == rowInd && j == colInd)
            {
                WriteLine($"{element} - элемент с индексом {rowInd},{colInd}");
                break;
            }
  
        }
    }
}