﻿/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

// Создаю переменные для строк и колонок - rows и colums соответственно с запросом на ввод
Console.Clear();
Console.Write("Пожалуйста, введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Пожалуйста, введите количество колонок: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
int[,] matrix = new int[rows,colums];
for(int i = 0; i < rows; i++){
    Console.WriteLine();
    for(int j = 0; j < colums; j++){
        matrix[i,j] = new Random().Next(-99,100);
        Console.Write(" " + matrix[i,j]);
    }
}
