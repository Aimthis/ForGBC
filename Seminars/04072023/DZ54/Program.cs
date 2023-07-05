/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
Console.Clear();
double[,] matrix = Array2d();
BubbleSortOfArray2d(matrix);
Console.WriteLine();
Array2dToConsole(matrix);

void Array2dToConsole(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
}

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
double[,] BubbleSortOfArray2d(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    double buffer = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = buffer;
                }
            }
        }
    }
    return matrix;
}




/*double sortMin = matrix[0, 0];
double sortMax = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] < matrix[i, j + 1])
            {
                double buffer = matrix[i, j + 1];
                matrix[i, j + 1] = matrix[i, j];
                matrix[i, j] = buffer;
            }
                        int oposite = (j - matrix.GetLength(1) - 1) * -1;
                        if (matrix[i, j] > matrix[i, oposite])
                        {
                            sortMin = matrix[i, oposite];
                            matrix[i, oposite] = matrix[i, j];
                            matrix[i, j] = sortMin;
                        }

        }
    }
}*/
