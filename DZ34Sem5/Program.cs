using System;
using static System.Console;

WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] arr = new int[size];
GetRanArray(arr);
WriteLine("Вывод массива: ");
PrintArray(arr);
int pozNum = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
pozNum++;

WriteLine($"В массиве {pozNum} чисел - чётные");

void GetRanArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
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