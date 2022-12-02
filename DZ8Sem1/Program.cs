using System;

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int Number = Convert.ToInt32(Console.ReadLine());
int CurentN = 1;

while (CurentN <= Number)
{
    if(CurentN % 2 == 0) Console.Write($"{CurentN}, ");
    //Console.Write(", ");
    CurentN++;
}
Console.WriteLine("End");