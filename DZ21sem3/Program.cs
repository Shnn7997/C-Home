//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

using System;
using static System.Console;

WriteLine("Введите координату X1: ");
int X1 = int.Parse(ReadLine());

WriteLine("Введите координату Y1: ");
int Y1 = int.Parse(ReadLine());

WriteLine("Введите координату X2: ");
int X2 = int.Parse(ReadLine());

WriteLine("Введите координату Y2: ");
int Y2 = int.Parse(ReadLine());

WriteLine("Введите координату Z1: ");
int Z1 = int.Parse(ReadLine());

WriteLine("Введите координату Z2: ");
int Z2 = int.Parse(ReadLine());

int X = X1 - X2;
int Y = Y1 - Y2;
int Z = Z1 - Z2;


double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
WriteLine($"Расстояние между точками в пространстве равно {distance:f2}");
ReadKey();

