/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Clear();
double[,] matrix = Array2d();
double[] allSums = SumOfRowsInArray2d(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов : {FindLowest(allSums)}");
int FindLowest(double[] plenty)
{
    double low = plenty[0];
    int lowestIndex = 0;
    for (int i = 0; i < plenty.Length - 1; i++)
    {
        if (low > plenty[i + 1])
        {
            low = plenty[i + 1];
            lowestIndex = i + 1;
        }
    }
    return lowestIndex;
}
Console.WriteLine();

double[,] Array2d()
{
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    // Создаем двумерный массив на 8-16 строк, столбцов и случайными значениями внутри от 0 до 999  
    double[,] matrix = new double[new Random().Next(8, 17), new Random().Next(8, 17)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 1000);
            Console.Write(" " + matrix[i, j]);
        }
        Console.WriteLine();
    }
    return matrix;
}
double[] SumOfRowsInArray2d(double[,] matrix)
{
    double rowSum = 0;
    double[] sum = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            rowSum += matrix[i, j];
        }
        sum[i] = rowSum;
        rowSum = 0;
    }
    return sum;
}
