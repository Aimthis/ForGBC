﻿// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Создаем двумерный массив на 4-6 строк, столбцов и случайными значениями внутри от 0 до 9 
double[,] matrix = new double[new Random().Next(4, 7), new Random().Next(4, 7)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(" " + matrix[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
double temp = 0;
for (int k = 0; k < matrix.GetLength(1); k++)
{
    temp = matrix[0, k];
    matrix[0, k] = matrix[matrix.GetLength(0) - 1, k];
    matrix[matrix.GetLength(0) - 1, k] = temp;
}
for (int l = 0; l < matrix.GetLength(0); l++)
{
    for (int m = 0; m < matrix.GetLength(1); m++)
    {
        Console.Write(" " + matrix[l, m]);
    }
    Console.WriteLine();
}
