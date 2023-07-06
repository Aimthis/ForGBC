/*Задача 62: Заполните спирально массив 4 на 4.*/



double[,] Array2dSpiralFill()
{
    Console.WriteLine("Создан двумерный массив содержащий следующие значения:");
    // Создаем двумерный массив на 4-4 строк, столбцов и значениями внутри по спирали от 1 с шагом в 1
    double[,] matrix = new double[new Random().Next(4, 5), new Random().Next(4, 5)];
    int fillValue = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = fillValue;
            fillValue++;
            Console.Write(" " + matrix[i, j]);
        }
        Console.WriteLine();
    }
    return matrix;
}