
using System;
using static System.Console;

WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] arr = new int[size];
GetRanArray(arr);
WriteLine("Вывод массива: ");
PrintArray(arr);
int razn = findMax(arr) - findMin(arr);
WriteLine($"Разница между максимальным и минимальным элементами равна {razn}");

void GetRanArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,100);
    }
}


void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Write(arr[i] + " ");
    }
WriteLine();
}

int findMin(int[] arr)
    {
        if (arr.Length == 0) {
            throw new Exception("Array is empty");
        }
        int min = int.MaxValue;
        foreach (var i in arr) {
            if (i < min) {
                min= i;
            }
        }
        return min;
    }


    int findMax(int[] arr)
    {
        if (arr.Length == 0) {
            throw new Exception("Array is empty");
        }
        int max = int.MinValue;
        foreach (var i in arr) {
            if (i > max) {
                max = i;
            }
        }
        return max;
    }
