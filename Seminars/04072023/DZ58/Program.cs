﻿/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
double[,] firstMatrix = Array2d();
double[,] secondMatrix = Array2d();

double[,] multiplication = new double[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];
Console.WriteLine("Результат перемножения");
for(int i= 0;i<multiplication.GetLength(0);i++){
    double resultofMult = 0;
    for(int j= 0;j<multiplication.GetLength(1);j++){
        for(int k=0;k<multiplication.GetLength(0);k++){
        resultofMult += firstMatrix[i,k]*secondMatrix[k,j];
        }
        multiplication[i,j] = resultofMult;
        resultofMult = 0;
        Console.Write(" " + multiplication[i, j]);
    }
    Console.WriteLine(" ");
}




double[,] Array2d()
{
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    // Создаем двумерный массив на 3-3 строк, столбцов и случайными значениями внутри от 0 до 9  
    double[,] matrix = new double[new Random().Next(3, 4), new Random().Next(3, 4)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(" " + matrix[i, j]);
        }
        Console.WriteLine();
    }
    return matrix;
}