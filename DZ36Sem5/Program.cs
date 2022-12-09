
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;
using static System.Console;

WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] arr = new int[size];
GetRanArray(arr);
WriteLine("Вывод массива: ");
PrintArray(arr);
int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
sum = sum + arr[i];

WriteLine($"Сумма элементов на нечётных позициях {sum}");

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